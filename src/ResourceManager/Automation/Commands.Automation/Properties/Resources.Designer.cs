﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Automation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Automation.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create account arguments are invalid. Provide valid account name and location. Account Name: {0}, Location: {1} .
        /// </summary>
        internal static string AccountCreateInvalidArgs {
            get {
                return ResourceManager.GetString("AccountCreateInvalidArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation account already exists.
        /// </summary>
        internal static string AutomationAccountAlreadyExists {
            get {
                return ResourceManager.GetString("AutomationAccountAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation account was not found..
        /// </summary>
        internal static string AutomationAccountNotFound {
            get {
                return ResourceManager.GetString("AutomationAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1} operation failed for object name: {2) under AutomationAccount: {3}.
        /// </summary>
        internal static string AutomationOperationFailed {
            get {
                return ResourceManager.GetString("AutomationOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate already exists. Certificate name: {0}..
        /// </summary>
        internal static string CertificateAlreadyExists {
            get {
                return ResourceManager.GetString("CertificateAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate was not found. Certificate name {0}..
        /// </summary>
        internal static string CertificateNotFound {
            get {
                return ResourceManager.GetString("CertificateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Compilation Job having Id: {0} was not found..
        /// </summary>
        internal static string CompilationJobNotFound {
            get {
                return ResourceManager.GetString("CompilationJobNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration already exists. Specify the parameter to force an overwrite. Configuration name: {0}.
        /// </summary>
        internal static string ConfigurationAlreadyExists {
            get {
                return ResourceManager.GetString("ConfigurationAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Content is not found for configuration name: {0}.
        /// </summary>
        internal static string ConfigurationContentNotFound {
            get {
                return ResourceManager.GetString("ConfigurationContentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration content can not be in edit/draft mode in current preview. Use the Published option..
        /// </summary>
        internal static string ConfigurationDraftMode {
            get {
                return ResourceManager.GetString("ConfigurationDraftMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration has no published version. Configuration name {0}..
        /// </summary>
        internal static string ConfigurationHasNoPublishedVersion {
            get {
                return ResourceManager.GetString("ConfigurationHasNoPublishedVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Dsc Configuration was not found. Configuration name {0}..
        /// </summary>
        internal static string ConfigurationNotFound {
            get {
                return ResourceManager.GetString("ConfigurationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration can be imported in published state only in the current preview. Use the -Published switch..
        /// </summary>
        internal static string ConfigurationNotPublished {
            get {
                return ResourceManager.GetString("ConfigurationNotPublished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration parameter cannot be serialized to json. Parameter name {0}..
        /// </summary>
        internal static string ConfigurationParameterCannotBeSerializedToJson {
            get {
                return ResourceManager.GetString("ConfigurationParameterCannotBeSerializedToJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration mandatory parameter not specified. Parameter name {0}..
        /// </summary>
        internal static string ConfigurationParameterValueRequired {
            get {
                return ResourceManager.GetString("ConfigurationParameterValueRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid SourcePath. Verify file path is valid and file exists..
        /// </summary>
        internal static string ConfigurationSourcePathInvalid {
            get {
                return ResourceManager.GetString("ConfigurationSourcePathInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection already exists. Connection name: {0}..
        /// </summary>
        internal static string ConnectionAlreadyExists {
            get {
                return ResourceManager.GetString("ConnectionAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection field name was not found for connection name: {0}..
        /// </summary>
        internal static string ConnectionFieldNameNotFound {
            get {
                return ResourceManager.GetString("ConnectionFieldNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection was not found. Connection name: {0}..
        /// </summary>
        internal static string ConnectionNotFound {
            get {
                return ResourceManager.GetString("ConnectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The credential was not found. Credential name: {0}..
        /// </summary>
        internal static string CredentialNotFound {
            get {
                return ResourceManager.GetString("CredentialNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating the metaconfiguration.
        /// </summary>
        internal static string DscMetaMofHasKeysDescription {
            get {
                return ResourceManager.GetString("DscMetaMofHasKeysDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: The files downloaded by this cmdlet contain the registration key for the specified Azure Automation account. This registration key allows computers to onboard to this Automation Account. Store these files in a secure location or delete them after use..
        /// </summary>
        internal static string DscMetaMofHasKeysWarning {
            get {
                return ResourceManager.GetString("DscMetaMofHasKeysWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Dsc node was not found. Node id {0}..
        /// </summary>
        internal static string DscNodeNotFound {
            get {
                return ResourceManager.GetString("DscNodeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid configuration parameters..
        /// </summary>
        internal static string InvalidConfigurationParameters {
            get {
                return ResourceManager.GetString("InvalidConfigurationParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid path {0}..
        /// </summary>
        internal static string InvalidFilePath {
            get {
                return ResourceManager.GetString("InvalidFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid folder path. Folder {0}..
        /// </summary>
        internal static string InvalidFolderPath {
            get {
                return ResourceManager.GetString("InvalidFolderPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid runbook parameters..
        /// </summary>
        internal static string InvalidRunbookParameters {
            get {
                return ResourceManager.GetString("InvalidRunbookParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Job having Id: {0} was not found..
        /// </summary>
        internal static string JobNotFound {
            get {
                return ResourceManager.GetString("JobNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job schedule was not found. Runbook name {0}. Schedule name {1}..
        /// </summary>
        internal static string JobScheduleNotFound {
            get {
                return ResourceManager.GetString("JobScheduleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job schedule was not found. Job schedule id: {0}..
        /// </summary>
        internal static string JobScheduleWithIdNotFound {
            get {
                return ResourceManager.GetString("JobScheduleWithIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metaconfig already exists. Specify the parameter to force an overwrite. File: {0}.
        /// </summary>
        internal static string MetaconfigAlreadyExists {
            get {
                return ResourceManager.GetString("MetaconfigAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The module was not found. Module name: {0}..
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A node configuration already exists. Specify the parameter to force an overwrite..
        /// </summary>
        internal static string NodeConfigurationAlreadyExists {
            get {
                return ResourceManager.GetString("NodeConfigurationAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NodeConfiguration {0} not found..
        /// </summary>
        internal static string NodeConfigurationNotFound {
            get {
                return ResourceManager.GetString("NodeConfigurationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node was not found..
        /// </summary>
        internal static string NodeNotFound {
            get {
                return ResourceManager.GetString("NodeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NodeReport already exists. Specify force switch an overwrite. File: {0}.
        /// </summary>
        internal static string NodeReportAlreadyExists {
            get {
                return ResourceManager.GetString("NodeReportAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} File(s) written to output folder.
        /// </summary>
        internal static string NumberOfFilesWritten {
            get {
                return ResourceManager.GetString("NumberOfFilesWritten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is empty..
        /// </summary>
        internal static string ParameterEmpty {
            get {
                return ResourceManager.GetString("ParameterEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to decrypt. Error Details {0}.
        /// </summary>
        internal static string PowershellJsonDecrypterFailed {
            get {
                return ResourceManager.GetString("PowershellJsonDecrypterFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disassociating the Azure Automation runbook and schedule..
        /// </summary>
        internal static string RemoveAzureAutomationJobScheduleDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationJobScheduleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to disassociate the Azure Automation runbook and schedule?.
        /// </summary>
        internal static string RemoveAzureAutomationJobScheduleWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationJobScheduleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation {0}..
        /// </summary>
        internal static string RemoveAzureAutomationResourceDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationResourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation runbook..
        /// </summary>
        internal static string RemoveAzureAutomationRunbookDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationRunbookDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation runbook?.
        /// </summary>
        internal static string RemoveAzureAutomationRunbookWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationRunbookWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Azure Automation schedule..
        /// </summary>
        internal static string RemoveAzureAutomationScheduleDescription {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation schedule?.
        /// </summary>
        internal static string RemoveAzureAutomationScheduleWarning {
            get {
                return ResourceManager.GetString("RemoveAzureAutomationScheduleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the Dsc node with Id {0}..
        /// </summary>
        internal static string RemoveDscNodeDescription {
            get {
                return ResourceManager.GetString("RemoveDscNodeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to unregister this node from Azure Automation DSC?.
        /// </summary>
        internal static string RemoveDscNodeWarning {
            get {
                return ResourceManager.GetString("RemoveDscNodeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Automation {0} ?.
        /// </summary>
        internal static string RemovingAzureAutomationResourceWarning {
            get {
                return ResourceManager.GetString("RemovingAzureAutomationResourceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource exist..
        /// </summary>
        internal static string ResourceExists {
            get {
                return ResourceManager.GetString("ResourceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource does not exist..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Runbook already exists. Runbook name: {0}..
        /// </summary>
        internal static string RunbookAlreadyExists {
            get {
                return ResourceManager.GetString("RunbookAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runbook already has a draft. Specify the parameter to force an overwrite of this draft. Runbook name: {0}.
        /// </summary>
        internal static string RunbookAlreadyHasDraft {
            get {
                return ResourceManager.GetString("RunbookAlreadyHasDraft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook has no draft version. Runbook name {0}..
        /// </summary>
        internal static string RunbookHasNoDraftVersion {
            get {
                return ResourceManager.GetString("RunbookHasNoDraftVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The runbook has no published version. Runbook name {0}..
        /// </summary>
        internal static string RunbookHasNoPublishedVersion {
            get {
                return ResourceManager.GetString("RunbookHasNoPublishedVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Runbook was not found. Runbook name: {0}..
        /// </summary>
        internal static string RunbookNotFound {
            get {
                return ResourceManager.GetString("RunbookNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runbook parameter cannot be serialized to json. Parameter name {0}..
        /// </summary>
        internal static string RunbookParameterCannotBeSerializedToJson {
            get {
                return ResourceManager.GetString("RunbookParameterCannotBeSerializedToJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runbook mandatory parameter not specified. Parameter name {0}..
        /// </summary>
        internal static string RunbookParameterValueRequired {
            get {
                return ResourceManager.GetString("RunbookParameterValueRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Automation schedule name is in use. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNameExists {
            get {
                return ResourceManager.GetString("ScheduleNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schedule was not found. Schedule name: {0}..
        /// </summary>
        internal static string ScheduleNotFound {
            get {
                return ResourceManager.GetString("ScheduleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password and Exportable parameters cannot be updated for an existing certificate. They can only be specified when overwriting this certificate with a new one, via the Path parameter.
        /// </summary>
        internal static string SetCertificateInvalidArgs {
            get {
                return ResourceManager.GetString("SetCertificateInvalidArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating the node configuration assignment for this node.
        /// </summary>
        internal static string SetnodeconfigurationDescription {
            get {
                return ResourceManager.GetString("SetnodeconfigurationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to update the node configuration assignment for this node?.
        /// </summary>
        internal static string SetnodeconfigurationWarning {
            get {
                return ResourceManager.GetString("SetnodeconfigurationWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unauthorized access to {0}..
        /// </summary>
        internal static string UnauthorizedAccess {
            get {
                return ResourceManager.GetString("UnauthorizedAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable already exists. Variable name {0}..
        /// </summary>
        internal static string VariableAlreadyExists {
            get {
                return ResourceManager.GetString("VariableAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change encryption property of the variable. Variable name {0}. Encryption - {1}..
        /// </summary>
        internal static string VariableEncryptionCannotBeChanged {
            get {
                return ResourceManager.GetString("VariableEncryptionCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable was not found. Variable name {0}..
        /// </summary>
        internal static string VariableNotFound {
            get {
                return ResourceManager.GetString("VariableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Webhook with Name: {0} was not found..
        /// </summary>
        internal static string WebhookNotFound {
            get {
                return ResourceManager.GetString("WebhookNotFound", resourceCulture);
            }
        }
    }
}
