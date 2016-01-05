// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    public partial class VirtualNetworkGatewayConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        public VirtualNetworkGatewayConnection() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        public VirtualNetworkGatewayConnection(string etag = default(string), string authorizationKey = default(string), VirtualNetworkGateway virtualNetworkGateway1 = default(VirtualNetworkGateway), VirtualNetworkGateway virtualNetworkGateway2 = default(VirtualNetworkGateway), LocalNetworkGateway localNetworkGateway2 = default(LocalNetworkGateway), string connectionType = default(string), int? routingWeight = default(int?), string sharedKey = default(string), string connectionStatus = default(string), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), SubResource peer = default(SubResource), string resourceGuid = default(string), string provisioningState = default(string))
        {
            Etag = etag;
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The authorizationKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public VirtualNetworkGateway VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public VirtualNetworkGateway VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public LocalNetworkGateway LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gateway connection type -Ipsec/Dedicated/VpnClient/Vnet2Vnet.
        /// Possible values for this property include: 'IPsec', 'Vnet2Vnet',
        /// 'ExpressRoute', 'VPNClient'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// The Routing weight.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// The Ipsec share key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Virtual network Gateway connection status. Possible values for
        /// this property include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// The Egress Bytes Transferred in this connection
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; set; }

        /// <summary>
        /// The Ingress Bytes Transferred in this connection
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; set; }

        /// <summary>
        /// The reference to peerings resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the
        /// VirtualNetworkGatewayConnection resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the
        /// VirtualNetworkGatewayConnection resource Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
