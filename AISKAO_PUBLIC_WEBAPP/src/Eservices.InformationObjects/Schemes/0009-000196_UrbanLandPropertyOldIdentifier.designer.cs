// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000196")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000196", IsNullable=true)]
    public partial class UrbanLandPropertyOldIdentifier : InformationObject<UrbanLandPropertyOldIdentifier> {
        
        private string cadastreNumberField;
        
        private string parcelField;
        
        private string quarterField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CadastreNumber {
            get {
                return this.cadastreNumberField;
            }
            set {
                if ((this.cadastreNumberField != null)) {
                    if ((cadastreNumberField.Equals(value) != true)) {
                        this.cadastreNumberField = value;
                        this.OnPropertyChanged("CadastreNumber");
                    }
                }
                else {
                    this.cadastreNumberField = value;
                    this.OnPropertyChanged("CadastreNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Parcel {
            get {
                return this.parcelField;
            }
            set {
                if ((this.parcelField != null)) {
                    if ((parcelField.Equals(value) != true)) {
                        this.parcelField = value;
                        this.OnPropertyChanged("Parcel");
                    }
                }
                else {
                    this.parcelField = value;
                    this.OnPropertyChanged("Parcel");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Quarter {
            get {
                return this.quarterField;
            }
            set {
                if ((this.quarterField != null)) {
                    if ((quarterField.Equals(value) != true)) {
                        this.quarterField = value;
                        this.OnPropertyChanged("Quarter");
                    }
                }
                else {
                    this.quarterField = value;
                    this.OnPropertyChanged("Quarter");
                }
            }
        }
    }
}
