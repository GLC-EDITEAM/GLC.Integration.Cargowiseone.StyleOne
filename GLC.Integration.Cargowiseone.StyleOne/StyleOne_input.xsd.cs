namespace GLC.Integration.Cargowiseone.StyleOne {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"Shipment")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Shipment"})]
    public sealed class StyleOne_Input : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Shipment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LocalProcessing"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DeliveryRequiredBy"" type=""xs:dateTime"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Order"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderNumber"" type=""xs:string"" />
              <xs:element name=""ClientReference"" type=""xs:string"" />
              <xs:element name=""TotalUnits"" type=""xs:unsignedByte"" />
              <xs:element name=""Type"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Code"" type=""xs:string"" />
                    <xs:element name=""Description"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Warehouse"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Code"" type=""xs:string"" />
                    <xs:element name=""Name"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OrderLineCollection"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""OrderLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""LineNumber"" type=""xs:unsignedByte"" />
                          <xs:element name=""OrderedQty"" type=""xs:unsignedByte"" />
                          <xs:element name=""OrderedQtyUnit"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Code"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""Product"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Code"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""Content"" type=""xs:string"" use=""required"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OrganizationAddressCollection"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""OrganizationAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""AddressType"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Address1"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Address2"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""AddressOverride"" type=""xs:boolean"" />
                    <xs:element minOccurs=""0"" name=""City"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""State"" type=""xs:string"" />
                    <xs:element name=""CompanyName"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""OrganizationCode"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Code"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""Postcode"" type=""xs:unsignedShort"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public StyleOne_Input() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Shipment";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
