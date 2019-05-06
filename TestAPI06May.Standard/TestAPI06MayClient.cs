/*
 * TestAPI06May.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using TestAPI06May.Standard.Controllers;
using TestAPI06May.Standard.Http.Client;
using TestAPI06May.Standard.Utilities;

namespace TestAPI06May.Standard
{
    public partial class TestAPI06MayClient
    {

        /// <summary>
        /// Singleton access to Items controller
        /// </summary>
        public ItemsController Items
        {
            get
            {
                return ItemsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Store controller
        /// </summary>
        public StoreController Store
        {
            get
            {
                return StoreController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public TestAPI06MayClient() { }
        #endregion
    }
}