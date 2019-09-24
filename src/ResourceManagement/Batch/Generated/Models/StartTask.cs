// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A task which is run when a compute node joins a pool in the Azure Batch
    /// service, or when the compute node is rebooted or reimaged.
    /// </summary>
    /// <remarks>
    /// In some cases the start task may be re-run even though the node was not
    /// rebooted. Due to this, start tasks should be idempotent and exit
    /// gracefully if the setup they're performing has already been done.
    /// Special care should be taken to avoid start tasks which create
    /// breakaway process or install/launch services from the start task
    /// working directory, as this will block Batch from being able to re-run
    /// the start task.
    /// </remarks>
    public partial class StartTask
    {
        /// <summary>
        /// Initializes a new instance of the StartTask class.
        /// </summary>
        public StartTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartTask class.
        /// </summary>
        /// <param name="commandLine">The command line of the start
        /// task.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the start task.</param>
        /// <param name="userIdentity">The user identity under which the start
        /// task runs.</param>
        /// <param name="maxTaskRetryCount">The maximum number of times the
        /// task may be retried.</param>
        /// <param name="waitForSuccess">Whether the Batch service should wait
        /// for the start task to complete successfully (that is, to exit with
        /// exit code 0) before scheduling any tasks on the compute
        /// node.</param>
        /// <param name="containerSettings">The settings for the container
        /// under which the start task runs.</param>
        public StartTask(string commandLine = default(string), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), UserIdentity userIdentity = default(UserIdentity), int? maxTaskRetryCount = default(int?), bool? waitForSuccess = default(bool?), TaskContainerSettings containerSettings = default(TaskContainerSettings))
        {
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            UserIdentity = userIdentity;
            MaxTaskRetryCount = maxTaskRetryCount;
            WaitForSuccess = waitForSuccess;
            ContainerSettings = containerSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the command line of the start task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using "cmd
        /// /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// Required if any other properties of the startTask are specified.
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the start
        /// task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the start task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task.
        /// </remarks>
        [JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of times the task may be retried.
        /// </summary>
        /// <remarks>
        /// The Batch service retries a task if its exit code is nonzero. Note
        /// that this value specifically controls the number of retries. The
        /// Batch service will try the task once, and may then retry up to this
        /// limit. For example, if the maximum retry count is 3, Batch tries
        /// the task up to 4 times (one initial try and 3 retries). If the
        /// maximum retry count is 0, the Batch service does not retry the
        /// task. If the maximum retry count is -1, the Batch service retries
        /// the task without limit.
        /// </remarks>
        [JsonProperty(PropertyName = "maxTaskRetryCount")]
        public int? MaxTaskRetryCount { get; set; }

        /// <summary>
        /// Gets or sets whether the Batch service should wait for the start
        /// task to complete successfully (that is, to exit with exit code 0)
        /// before scheduling any tasks on the compute node.
        /// </summary>
        /// <remarks>
        /// If true and the start task fails on a compute node, the Batch
        /// service retries the start task up to its maximum retry count
        /// (maxTaskRetryCount). If the task has still not completed
        /// successfully after all retries, then the Batch service marks the
        /// compute node unusable, and will not schedule tasks to it. This
        /// condition can be detected via the node state and scheduling error
        /// detail. If false, the Batch service will not wait for the start
        /// task to complete. In this case, other tasks can start executing on
        /// the compute node while the start task is still running; and even if
        /// the start task fails, new tasks will continue to be scheduled on
        /// the node. The default is true.
        /// </remarks>
        [JsonProperty(PropertyName = "waitForSuccess")]
        public bool? WaitForSuccess { get; set; }

        /// <summary>
        /// Gets or sets the settings for the container under which the start
        /// task runs.
        /// </summary>
        /// <remarks>
        /// When this is specified, all directories recursively below the
        /// AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the
        /// node) are mapped into the container, all task environment variables
        /// are mapped into the container, and the task command line is
        /// executed in the container.
        /// </remarks>
        [JsonProperty(PropertyName = "containerSettings")]
        public TaskContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EnvironmentSettings != null)
            {
                foreach (var element in EnvironmentSettings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ContainerSettings != null)
            {
                ContainerSettings.Validate();
            }
        }
    }
}
