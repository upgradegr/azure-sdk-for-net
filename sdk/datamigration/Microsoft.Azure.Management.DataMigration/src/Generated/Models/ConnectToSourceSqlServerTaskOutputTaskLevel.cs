// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Task level output for the task that validates connection to SQL Server
    /// and also validates source server requirements
    /// </summary>
    [Newtonsoft.Json.JsonObject("TaskLevelOutput")]
    public partial class ConnectToSourceSqlServerTaskOutputTaskLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputTaskLevel class.
        /// </summary>
        public ConnectToSourceSqlServerTaskOutputTaskLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputTaskLevel class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="databases">Source databases as a map from database
        /// name to database id</param>
        /// <param name="logins">Source logins as a map from login name to
        /// login id.</param>
        /// <param name="agentJobs">Source agent jobs as a map from agent job
        /// name to id.</param>
        /// <param name="databaseTdeCertificateMapping">Mapping from database
        /// name to TDE certificate name, if applicable</param>
        /// <param name="sourceServerVersion">Source server version</param>
        /// <param name="sourceServerBrandVersion">Source server brand
        /// version</param>
        /// <param name="validationErrors">Validation errors</param>
        public ConnectToSourceSqlServerTaskOutputTaskLevel(string id = default(string), IDictionary<string, string> databases = default(IDictionary<string, string>), IDictionary<string, string> logins = default(IDictionary<string, string>), IDictionary<string, string> agentJobs = default(IDictionary<string, string>), IDictionary<string, string> databaseTdeCertificateMapping = default(IDictionary<string, string>), string sourceServerVersion = default(string), string sourceServerBrandVersion = default(string), IList<ReportableException> validationErrors = default(IList<ReportableException>))
            : base(id)
        {
            Databases = databases;
            Logins = logins;
            AgentJobs = agentJobs;
            DatabaseTdeCertificateMapping = databaseTdeCertificateMapping;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets source databases as a map from database name to database id
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IDictionary<string, string> Databases { get; private set; }

        /// <summary>
        /// Gets source logins as a map from login name to login id.
        /// </summary>
        [JsonProperty(PropertyName = "logins")]
        public IDictionary<string, string> Logins { get; private set; }

        /// <summary>
        /// Gets source agent jobs as a map from agent job name to id.
        /// </summary>
        [JsonProperty(PropertyName = "agentJobs")]
        public IDictionary<string, string> AgentJobs { get; private set; }

        /// <summary>
        /// Gets mapping from database name to TDE certificate name, if
        /// applicable
        /// </summary>
        [JsonProperty(PropertyName = "databaseTdeCertificateMapping")]
        public IDictionary<string, string> DatabaseTdeCertificateMapping { get; private set; }

        /// <summary>
        /// Gets source server version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerVersion")]
        public string SourceServerVersion { get; private set; }

        /// <summary>
        /// Gets source server brand version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerBrandVersion")]
        public string SourceServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets validation errors
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}