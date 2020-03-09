# Introduction
As P97 continues to add additional tenants and custom workflows to common processes, the need arose to make these custom workflows
almost fully configurable, without directly making changes to code.  This will be accomplished through breaking the present software
up into a set of microservices, which will handle - and subsequently raise - events.  As for which events get handled by which
microservice methods, and what sets of data are passed into these methods, this will be handled by a common orchestrator service,
which will at least initially be heavily connected with the Service Bus.

This orchestrator will be referred to as Atlas.  Atlas will take certain meta-information, such as the tenant and the application
used, and load custom configurations for these criteria that map the routing of events.  When a new custom workflow enters the
picture, this will allow it to be implemented without changing ordinary code.

# Hierarchal Naming of Event Types
Atlas configurations will route events to their handlers according to event type.  For any given custom or default Atlas
configuration, each event type will have one configuration for how it is to be handled/routed.

Essentially therefore each event type will be comprised of several smaller components.  It is directly comparable with a person's
name.  For example, if a given person has the name of Michelle Patricia Adams, this name can often be broken down into a first,
middle, and last name.  We will be doing the same thing with event types, with the following components:

```
1. Type [A very broad umbrella type, essentially the same thing as a last/family name.]
2. Flow
3. Operation
4. Result
5. Version
```

These five components together will represent a single, exact event type, which will be routed by Atlas.  The five of them, in order,
will be used to comprise the name of that event type as follows:

`TYPE_FLOW_OPERATION_RESULT_VERSION`

For example:

`INSTORE_TXNFINALIZE_UPSERTTRANSACTIONDISCOUNTS_COMPLETE_1`

# Format for the Configuration for a Single Event Type (Event Configuration)
This will likely need to be specified in detail in a separate document, but only vaguely here.

For any given Atlas configuration (custom overall configuration for Atlas for a given Tenant, application, etc.), ALL event types
MUST have event configurations specified.  Within that Atlas configuration, each type of event must have one and only one event
configuration.  A given event type's configuration may have zero, one, or multiple handlers; that is not important.  However even if
there are no handlers to which to route the event, there must be an explicit configuration that specifies that.

Each event type's configuration will essentially be in the form of a JSON object.

# Layout of a Full Set of Event Handlers (Atlas Configuration)
For any given Atlas configuration (custom overall configuration for all the events in Atlas), each specific event type's handler will
be stored completely separately.  In other words, the different events and handlers will not be consolidated into a single JSON
object for the entire system.  They will all be in completely separate files, SQL items, or other storage units.

However these separate configurations will be grouped into categories and subcategories, directly comparable to a directory structure
on a typical file system.  These categories and subcategories will be the same as event type hierarchy/naming components, though in a
different order:

```
1. Version <The root category/"folder".>
2. Type
3. Flow
4. Operation
5. Result
```

At the location specified by `<Version>/<Type>/<Flow>/<Operation>/<Result>`, you would have a single event type's configuration.  So
for example, for the following event type:

`INSTORE_TXNFINALIZE_UPSERTTRANSACTIONDISCOUNTS_COMPLETE_1`

you would go to this location to find its event configuration for the given Atlas configuration:

`1/instore/txn_finalize/uperst_transaction_discounts/complete`

This structure pertains to a single Atlas configuration (for a specific tenant, application, and so on).  Each individual custom
Atlas config will have a separate copy of this structure.

# Persistence of Events
As events are received by Atlas, it will be generally necessary to persist them.  To do so in an efficient manner, event sourcing
will be used.

As events come in, Atlas will keep track of which events are related to which other events.  As a given user uses our system to
perform a certain task, many different events may be raised and routed in sequence to perform this task.  Together, this sequence of
events will implement a given workflow.  However other users may go through the same workflow, raising the same events, and the same
user may do the same thing multiple times.  Atlas will keep track of each sequence of events separately from each other sequence.

This will be comparable to streaming off of YouTube.  YouTube has a list of videos, and it is streaming them to different users.
Each video has a different set of data that is stream.  This is similar to a workflow in Atlas.  Each time a user streams that video,
this is similar to a sequence of related events in Atlas.  Different users may stream the same video at the same time, and the same
user may revisit the same video multiple times, but YouTube keeps track of each stream separately.  This is similar to Atlas keeping
track of each sequence of events separately.

To persist events, Atlas will use event sourcing, but it will break up the event sourcing through the use of snapshots.  In this way,
Atlas will persist a sequence of events similarly to how a video is streamed.

When a video is streamed, it starts with all of the data for a given frame - all of the visual and auidal data needed to present that
frame.  But then as it goes from frame to frame, it doesn't just keep sending all of that data separately for each frame.  Instead it
just sends the deltas - the visual and audial data that actually changed since the last frame.  As it moves from frame to frame,
instead of sending a full sheet of data, it just keeps sending the changes since the last frame, over and over again.  As the client
machine receives this data, it starts with the original frame - which had a complete set of data - and keeps applying these deltas on
top of each other, to know what to present at any given point in time.

As time goes on though, this can start working more and more poorly.  To fix that, video streams will occasionally send a frame with
a full set of data - just like they did with the first frame initially - instead of sending a delta.  Just like at the beginning, the
client machine can take this new frame and use it by itself to present that moment of the stream to the user.  This new frame is a
complete, self-contained snapshot of the present moment in the video stream.  It is called a keyframe.

As the stream continues, it will go back to sending deltas, but the client machine will always apply this new set of deltas to the
most recent snapshot, the most recent keyframe.  The client machine will always disregard what had come before that last keyframe.
And as time goes on, the stream will send a series of deltas, then send a new keyframe, then send a series of deltas, then a new
keyframe, and so on until the stream is ended.  In this way, the video stream is compression and efficient, through sending the
deltas, but it is also reliable and so on, through occassionally sending the keyframes.

Atlas will persist its events in the same exact manner.  It will use event sourcing, which the same as when video streams send a
series of deltas.  It will also use "Snapshots", which are directly analogous to keyframes.  (In Atlas's case though, the Snapshots
may, at least in some cases, be less of a reliability mechanism and more of a read-efficiency mechanism.)