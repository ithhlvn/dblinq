﻿#region MIT license
// 
// Copyright (c) 2007-2008 Jiri Moudry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
#endregion
namespace DbLinq.Schema.Dbml {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007", IsNullable=false)]
    public partial class Database : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Connection connectionField;
        
        private Table[] tableField;
        
        private Function[] functionField;
        
        private string nameField;
        
        private string entityNamespaceField;
        
        private string contextNamespaceField;
        
        private string classField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private ClassModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        private string baseTypeField;
        
        private string providerField;
        
        private bool externalMappingField;
        
        private bool externalMappingFieldSpecified;
        
        private SerializationMode serializationField;
        
        private bool serializationFieldSpecified;
        
        private string entityBaseField;
        
        /// <remarks/>
        public Connection Connection {
            get {
                return this.connectionField;
            }
            set {
                this.connectionField = value;
                this.RaisePropertyChanged("Connection");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Table")]
        public Table[] Table {
            get {
                return this.tableField;
            }
            set {
                this.tableField = value;
                this.RaisePropertyChanged("Table");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function")]
        public Function[] Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
                this.RaisePropertyChanged("Function");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityNamespace {
            get {
                return this.entityNamespaceField;
            }
            set {
                this.entityNamespaceField = value;
                this.RaisePropertyChanged("EntityNamespace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContextNamespace {
            get {
                return this.contextNamespaceField;
            }
            set {
                this.contextNamespaceField = value;
                this.RaisePropertyChanged("ContextNamespace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("Class");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ClassModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BaseType {
            get {
                return this.baseTypeField;
            }
            set {
                this.baseTypeField = value;
                this.RaisePropertyChanged("BaseType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider {
            get {
                return this.providerField;
            }
            set {
                this.providerField = value;
                this.RaisePropertyChanged("Provider");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExternalMapping {
            get {
                return this.externalMappingField;
            }
            set {
                this.externalMappingField = value;
                this.RaisePropertyChanged("ExternalMapping");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalMappingSpecified {
            get {
                return this.externalMappingFieldSpecified;
            }
            set {
                this.externalMappingFieldSpecified = value;
                this.RaisePropertyChanged("ExternalMappingSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SerializationMode Serialization {
            get {
                return this.serializationField;
            }
            set {
                this.serializationField = value;
                this.RaisePropertyChanged("Serialization");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerializationSpecified {
            get {
                return this.serializationFieldSpecified;
            }
            set {
                this.serializationFieldSpecified = value;
                this.RaisePropertyChanged("SerializationSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityBase {
            get {
                return this.entityBaseField;
            }
            set {
                this.entityBaseField = value;
                this.RaisePropertyChanged("EntityBase");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Connection : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string providerField;
        
        private ConnectionMode modeField;
        
        private bool modeFieldSpecified;
        
        private string connectionStringField;
        
        private string settingsObjectNameField;
        
        private string settingsPropertyNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider {
            get {
                return this.providerField;
            }
            set {
                this.providerField = value;
                this.RaisePropertyChanged("Provider");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ConnectionMode Mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
                this.RaisePropertyChanged("Mode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModeSpecified {
            get {
                return this.modeFieldSpecified;
            }
            set {
                this.modeFieldSpecified = value;
                this.RaisePropertyChanged("ModeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConnectionString {
            get {
                return this.connectionStringField;
            }
            set {
                this.connectionStringField = value;
                this.RaisePropertyChanged("ConnectionString");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SettingsObjectName {
            get {
                return this.settingsObjectNameField;
            }
            set {
                this.settingsObjectNameField = value;
                this.RaisePropertyChanged("SettingsObjectName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SettingsPropertyName {
            get {
                return this.settingsPropertyNameField;
            }
            set {
                this.settingsPropertyNameField = value;
                this.RaisePropertyChanged("SettingsPropertyName");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum ConnectionMode {
        
        /// <remarks/>
        ConnectionString,
        
        /// <remarks/>
        AppSettings,
        
        /// <remarks/>
        WebSettings,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Return : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string typeField;
        
        private string dbTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DbType {
            get {
                return this.dbTypeField;
            }
            set {
                this.dbTypeField = value;
                this.RaisePropertyChanged("DbType");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Parameter : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string parameter1Field;
        
        private string typeField;
        
        private string dbTypeField;
        
        private ParameterDirection directionField;
        
        private bool directionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("Parameter")]
        public string Parameter1 {
            get {
                return this.parameter1Field;
            }
            set {
                this.parameter1Field = value;
                this.RaisePropertyChanged("Parameter1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DbType {
            get {
                return this.dbTypeField;
            }
            set {
                this.dbTypeField = value;
                this.RaisePropertyChanged("DbType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ParameterDirection Direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
                this.RaisePropertyChanged("Direction");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
                this.RaisePropertyChanged("DirectionSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum ParameterDirection {
        
        /// <remarks/>
        In,
        
        /// <remarks/>
        Out,
        
        /// <remarks/>
        InOut,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Function : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Parameter[] parameterField;
        
        private object[] itemsField;
        
        private string nameField;
        
        private string idField;
        
        private string methodField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private MemberModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        private bool hasMultipleResultsField;
        
        private bool hasMultipleResultsFieldSpecified;
        
        private bool isComposableField;
        
        private bool isComposableFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public Parameter[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("Parameter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElementType", typeof(Type))]
        [System.Xml.Serialization.XmlElementAttribute("Return", typeof(Return))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
                this.RaisePropertyChanged("Method");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MemberModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasMultipleResults {
            get {
                return this.hasMultipleResultsField;
            }
            set {
                this.hasMultipleResultsField = value;
                this.RaisePropertyChanged("HasMultipleResults");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMultipleResultsSpecified {
            get {
                return this.hasMultipleResultsFieldSpecified;
            }
            set {
                this.hasMultipleResultsFieldSpecified = value;
                this.RaisePropertyChanged("HasMultipleResultsSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsComposable {
            get {
                return this.isComposableField;
            }
            set {
                this.isComposableField = value;
                this.RaisePropertyChanged("IsComposable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsComposableSpecified {
            get {
                return this.isComposableFieldSpecified;
            }
            set {
                this.isComposableFieldSpecified = value;
                this.RaisePropertyChanged("IsComposableSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Type : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object[] itemsField;
        
        private Type[] type1Field;
        
        private string idRefField;
        
        private string idField;
        
        private string nameField;
        
        private string inheritanceCodeField;
        
        private bool isInheritanceDefaultField;
        
        private bool isInheritanceDefaultFieldSpecified;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private ClassModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Association", typeof(Association))]
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(Column))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type")]
        public Type[] Type1 {
            get {
                return this.type1Field;
            }
            set {
                this.type1Field = value;
                this.RaisePropertyChanged("Type1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string IdRef {
            get {
                return this.idRefField;
            }
            set {
                this.idRefField = value;
                this.RaisePropertyChanged("IdRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InheritanceCode {
            get {
                return this.inheritanceCodeField;
            }
            set {
                this.inheritanceCodeField = value;
                this.RaisePropertyChanged("InheritanceCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsInheritanceDefault {
            get {
                return this.isInheritanceDefaultField;
            }
            set {
                this.isInheritanceDefaultField = value;
                this.RaisePropertyChanged("IsInheritanceDefault");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsInheritanceDefaultSpecified {
            get {
                return this.isInheritanceDefaultFieldSpecified;
            }
            set {
                this.isInheritanceDefaultFieldSpecified = value;
                this.RaisePropertyChanged("IsInheritanceDefaultSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ClassModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Association : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string memberField;
        
        private string storageField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private MemberModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        private string typeField;
        
        private string thisKeyField;
        
        private string otherKeyField;
        
        private bool isForeignKeyField;
        
        private bool isForeignKeyFieldSpecified;
        
        private Cardinality cardinalityField;
        
        private bool cardinalityFieldSpecified;
        
        private string deleteRuleField;
        
        private bool deleteOnNullField;
        
        private bool deleteOnNullFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
                this.RaisePropertyChanged("Member");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Storage {
            get {
                return this.storageField;
            }
            set {
                this.storageField = value;
                this.RaisePropertyChanged("Storage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MemberModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ThisKey {
            get {
                return this.thisKeyField;
            }
            set {
                this.thisKeyField = value;
                this.RaisePropertyChanged("ThisKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherKey {
            get {
                return this.otherKeyField;
            }
            set {
                this.otherKeyField = value;
                this.RaisePropertyChanged("OtherKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsForeignKey {
            get {
                return this.isForeignKeyField;
            }
            set {
                this.isForeignKeyField = value;
                this.RaisePropertyChanged("IsForeignKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsForeignKeySpecified {
            get {
                return this.isForeignKeyFieldSpecified;
            }
            set {
                this.isForeignKeyFieldSpecified = value;
                this.RaisePropertyChanged("IsForeignKeySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Cardinality Cardinality {
            get {
                return this.cardinalityField;
            }
            set {
                this.cardinalityField = value;
                this.RaisePropertyChanged("Cardinality");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CardinalitySpecified {
            get {
                return this.cardinalityFieldSpecified;
            }
            set {
                this.cardinalityFieldSpecified = value;
                this.RaisePropertyChanged("CardinalitySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DeleteRule {
            get {
                return this.deleteRuleField;
            }
            set {
                this.deleteRuleField = value;
                this.RaisePropertyChanged("DeleteRule");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DeleteOnNull {
            get {
                return this.deleteOnNullField;
            }
            set {
                this.deleteOnNullField = value;
                this.RaisePropertyChanged("DeleteOnNull");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteOnNullSpecified {
            get {
                return this.deleteOnNullFieldSpecified;
            }
            set {
                this.deleteOnNullFieldSpecified = value;
                this.RaisePropertyChanged("DeleteOnNullSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum AccessModifier {
        
        /// <remarks/>
        Public,
        
        /// <remarks/>
        Internal,
        
        /// <remarks/>
        Protected,
        
        /// <remarks/>
        ProtectedInternal,
        
        /// <remarks/>
        Private,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum MemberModifier {
        
        /// <remarks/>
        Virtual,
        
        /// <remarks/>
        Override,
        
        /// <remarks/>
        New,
        
        /// <remarks/>
        NewVirtual,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum Cardinality {
        
        /// <remarks/>
        One,
        
        /// <remarks/>
        Many,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Column : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string memberField;
        
        private string storageField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private MemberModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        private string typeField;
        
        private string dbTypeField;
        
        private bool isReadOnlyField;
        
        private bool isReadOnlyFieldSpecified;
        
        private bool isPrimaryKeyField;
        
        private bool isPrimaryKeyFieldSpecified;
        
        private bool isDbGeneratedField;
        
        private bool isDbGeneratedFieldSpecified;
        
        private bool canBeNullField;
        
        private bool canBeNullFieldSpecified;
        
        private UpdateCheck updateCheckField;
        
        private bool updateCheckFieldSpecified;
        
        private bool isDiscriminatorField;
        
        private bool isDiscriminatorFieldSpecified;
        
        private string expressionField;
        
        private bool isVersionField;
        
        private bool isVersionFieldSpecified;
        
        private bool isDelayLoadedField;
        
        private bool isDelayLoadedFieldSpecified;
        
        private AutoSync autoSyncField;
        
        private bool autoSyncFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
                this.RaisePropertyChanged("Member");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Storage {
            get {
                return this.storageField;
            }
            set {
                this.storageField = value;
                this.RaisePropertyChanged("Storage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MemberModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DbType {
            get {
                return this.dbTypeField;
            }
            set {
                this.dbTypeField = value;
                this.RaisePropertyChanged("DbType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsReadOnly {
            get {
                return this.isReadOnlyField;
            }
            set {
                this.isReadOnlyField = value;
                this.RaisePropertyChanged("IsReadOnly");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsReadOnlySpecified {
            get {
                return this.isReadOnlyFieldSpecified;
            }
            set {
                this.isReadOnlyFieldSpecified = value;
                this.RaisePropertyChanged("IsReadOnlySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPrimaryKey {
            get {
                return this.isPrimaryKeyField;
            }
            set {
                this.isPrimaryKeyField = value;
                this.RaisePropertyChanged("IsPrimaryKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPrimaryKeySpecified {
            get {
                return this.isPrimaryKeyFieldSpecified;
            }
            set {
                this.isPrimaryKeyFieldSpecified = value;
                this.RaisePropertyChanged("IsPrimaryKeySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsDbGenerated {
            get {
                return this.isDbGeneratedField;
            }
            set {
                this.isDbGeneratedField = value;
                this.RaisePropertyChanged("IsDbGenerated");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDbGeneratedSpecified {
            get {
                return this.isDbGeneratedFieldSpecified;
            }
            set {
                this.isDbGeneratedFieldSpecified = value;
                this.RaisePropertyChanged("IsDbGeneratedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CanBeNull {
            get {
                return this.canBeNullField;
            }
            set {
                this.canBeNullField = value;
                this.RaisePropertyChanged("CanBeNull");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanBeNullSpecified {
            get {
                return this.canBeNullFieldSpecified;
            }
            set {
                this.canBeNullFieldSpecified = value;
                this.RaisePropertyChanged("CanBeNullSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UpdateCheck UpdateCheck {
            get {
                return this.updateCheckField;
            }
            set {
                this.updateCheckField = value;
                this.RaisePropertyChanged("UpdateCheck");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateCheckSpecified {
            get {
                return this.updateCheckFieldSpecified;
            }
            set {
                this.updateCheckFieldSpecified = value;
                this.RaisePropertyChanged("UpdateCheckSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsDiscriminator {
            get {
                return this.isDiscriminatorField;
            }
            set {
                this.isDiscriminatorField = value;
                this.RaisePropertyChanged("IsDiscriminator");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDiscriminatorSpecified {
            get {
                return this.isDiscriminatorFieldSpecified;
            }
            set {
                this.isDiscriminatorFieldSpecified = value;
                this.RaisePropertyChanged("IsDiscriminatorSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
                this.RaisePropertyChanged("Expression");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsVersion {
            get {
                return this.isVersionField;
            }
            set {
                this.isVersionField = value;
                this.RaisePropertyChanged("IsVersion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsVersionSpecified {
            get {
                return this.isVersionFieldSpecified;
            }
            set {
                this.isVersionFieldSpecified = value;
                this.RaisePropertyChanged("IsVersionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsDelayLoaded {
            get {
                return this.isDelayLoadedField;
            }
            set {
                this.isDelayLoadedField = value;
                this.RaisePropertyChanged("IsDelayLoaded");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDelayLoadedSpecified {
            get {
                return this.isDelayLoadedFieldSpecified;
            }
            set {
                this.isDelayLoadedFieldSpecified = value;
                this.RaisePropertyChanged("IsDelayLoadedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AutoSync AutoSync {
            get {
                return this.autoSyncField;
            }
            set {
                this.autoSyncField = value;
                this.RaisePropertyChanged("AutoSync");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoSyncSpecified {
            get {
                return this.autoSyncFieldSpecified;
            }
            set {
                this.autoSyncFieldSpecified = value;
                this.RaisePropertyChanged("AutoSyncSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum UpdateCheck {
        
        /// <remarks/>
        Always,
        
        /// <remarks/>
        Never,
        
        /// <remarks/>
        WhenChanged,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum AutoSync {
        
        /// <remarks/>
        Never,
        
        /// <remarks/>
        OnInsert,
        
        /// <remarks/>
        OnUpdate,
        
        /// <remarks/>
        Always,
        
        /// <remarks/>
        Default,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum ClassModifier {
        
        /// <remarks/>
        Sealed,
        
        /// <remarks/>
        Abstract,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class TableFunctionReturn : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string memberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
                this.RaisePropertyChanged("Member");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class TableFunctionParameter : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string parameterField;
        
        private string memberField;
        
        private Version versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("Parameter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
                this.RaisePropertyChanged("Member");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Version Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("Version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VersionSpecified {
            get {
                return this.versionFieldSpecified;
            }
            set {
                this.versionFieldSpecified = value;
                this.RaisePropertyChanged("VersionSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum Version {
        
        /// <remarks/>
        Current,
        
        /// <remarks/>
        Original,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class TableFunction : object, System.ComponentModel.INotifyPropertyChanged {
        
        private TableFunctionParameter[] argumentField;
        
        private TableFunctionReturn returnField;
        
        private string functionIdField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Argument")]
        public TableFunctionParameter[] Argument {
            get {
                return this.argumentField;
            }
            set {
                this.argumentField = value;
                this.RaisePropertyChanged("Argument");
            }
        }
        
        /// <remarks/>
        public TableFunctionReturn Return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
                this.RaisePropertyChanged("Return");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string FunctionId {
            get {
                return this.functionIdField;
            }
            set {
                this.functionIdField = value;
                this.RaisePropertyChanged("FunctionId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public partial class Table : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Type typeField;
        
        private TableFunction insertFunctionField;
        
        private TableFunction updateFunctionField;
        
        private TableFunction deleteFunctionField;
        
        private string nameField;
        
        private string memberField;
        
        private AccessModifier accessModifierField;
        
        private bool accessModifierFieldSpecified;
        
        private MemberModifier modifierField;
        
        private bool modifierFieldSpecified;
        
        /// <remarks/>
        public Type Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }
        
        /// <remarks/>
        public TableFunction InsertFunction {
            get {
                return this.insertFunctionField;
            }
            set {
                this.insertFunctionField = value;
                this.RaisePropertyChanged("InsertFunction");
            }
        }
        
        /// <remarks/>
        public TableFunction UpdateFunction {
            get {
                return this.updateFunctionField;
            }
            set {
                this.updateFunctionField = value;
                this.RaisePropertyChanged("UpdateFunction");
            }
        }
        
        /// <remarks/>
        public TableFunction DeleteFunction {
            get {
                return this.deleteFunctionField;
            }
            set {
                this.deleteFunctionField = value;
                this.RaisePropertyChanged("DeleteFunction");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
                this.RaisePropertyChanged("Member");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessModifier AccessModifier {
            get {
                return this.accessModifierField;
            }
            set {
                this.accessModifierField = value;
                this.RaisePropertyChanged("AccessModifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessModifierSpecified {
            get {
                return this.accessModifierFieldSpecified;
            }
            set {
                this.accessModifierFieldSpecified = value;
                this.RaisePropertyChanged("AccessModifierSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MemberModifier Modifier {
            get {
                return this.modifierField;
            }
            set {
                this.modifierField = value;
                this.RaisePropertyChanged("Modifier");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifierSpecified {
            get {
                return this.modifierFieldSpecified;
            }
            set {
                this.modifierFieldSpecified = value;
                this.RaisePropertyChanged("ModifierSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/linqtosql/dbml/2007")]
    public enum SerializationMode {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Unidirectional,
    }
}
