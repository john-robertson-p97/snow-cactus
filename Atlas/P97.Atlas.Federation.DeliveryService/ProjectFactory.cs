﻿using P97.Atlas.Federation.DeliveryService.Business;
using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;
using P97.Atlas.Federation.DeliveryService.DataAccess;

namespace P97.Atlas.Federation.DeliveryService
{
    /// <summary>
    ///     The overall factory class for the <see cref="DeliveryService"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasDeliveryService"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasDeliveryService"/>.
        /// </returns>
        public IAtlasDeliveryService NewAtlasDeliveryService() =>
            new AtlasDeliveryService(_projectFactory.NewMicroserviceProxy(), new AddressDataAccess());

        private readonly Microservices.ProjectFactory _projectFactory = new Microservices.ProjectFactory();
    }
}