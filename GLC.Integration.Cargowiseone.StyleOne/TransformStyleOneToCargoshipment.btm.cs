namespace GLC.Integration.Cargowiseone.StyleOne {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.Cargowiseone.StyleOne.StyleOne_Input", typeof(global::GLC.Integration.Cargowiseone.StyleOne.StyleOne_Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    public sealed class TransformStyleOneToCargoshipment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.cargowise.com/Schemas/Universal/2011/11"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/Shipment"" />
  </xsl:template>
  <xsl:template match=""/Shipment"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;GDS&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;US&quot;)"" />
    <!--<xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCGDSTRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCGDSLAX&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;GLC&quot;)"" />
    <!--<xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;TRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;GDS&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;WarehouseOrder&quot;)"" />
    <ns0:UniversalShipment>
      <ns0:Shipment>
        <ns0:DataContext>
          <ns0:Company>
            <ns0:Code>
              <xsl:value-of select=""$var:v1"" />
            </ns0:Code>
            <ns0:Country>
              <ns0:Code>
                <xsl:value-of select=""$var:v2"" />
              </ns0:Code>
            </ns0:Country>
          </ns0:Company>
          <ns0:DataProvider>
            <xsl:value-of select=""$var:v3"" />
          </ns0:DataProvider>
          <ns0:EnterpriseID>
            <xsl:value-of select=""$var:v4"" />
          </ns0:EnterpriseID>
          <ns0:ServerID>
            <xsl:value-of select=""$var:v5"" />
          </ns0:ServerID>
          <ns0:DataTargetCollection>
            <ns0:DataTarget>
              <ns0:Type>
                <xsl:value-of select=""$var:v6"" />
              </ns0:Type>
            </ns0:DataTarget>
          </ns0:DataTargetCollection>
        </ns0:DataContext>
        <ns0:LocalProcessing>
          <ns0:DeliveryRequiredBy>
            <xsl:value-of select=""LocalProcessing/DeliveryRequiredBy/text()"" />
          </ns0:DeliveryRequiredBy>
        </ns0:LocalProcessing>
        <ns0:Order>
          <ns0:OrderNumber>
            <xsl:value-of select=""Order/OrderNumber/text()"" />
          </ns0:OrderNumber>
          <ns0:ClientReference>
            <xsl:value-of select=""Order/ClientReference/text()"" />
          </ns0:ClientReference>
          <ns0:TotalUnits>
            <xsl:value-of select=""Order/TotalUnits/text()"" />
          </ns0:TotalUnits>
          <ns0:Type>
            <ns0:Code>
              <xsl:value-of select=""Order/Type/Code/text()"" />
            </ns0:Code>
            <ns0:Description>
              <xsl:value-of select=""Order/Type/Description/text()"" />
            </ns0:Description>
          </ns0:Type>
          <ns0:Warehouse>
            <ns0:Code>
              <xsl:value-of select=""Order/Warehouse/Code/text()"" />
            </ns0:Code>
            <ns0:Name>
              <xsl:value-of select=""Order/Warehouse/Name/text()"" />
            </ns0:Name>
          </ns0:Warehouse>
          <ns0:OrderLineCollection>
            <xsl:for-each select=""Order/OrderLineCollection/OrderLine"">
            <ns0:OrderLine>
              <ns0:LineNumber>
                <xsl:value-of select=""LineNumber/text()"" />
              </ns0:LineNumber>
              <ns0:OrderedQty>
                <xsl:value-of select=""OrderedQty/text()"" />
              </ns0:OrderedQty>
              <ns0:OrderedQtyUnit>
                <ns0:Code>
                  <xsl:value-of select=""OrderedQtyUnit/Code/text()"" />
                </ns0:Code>
              </ns0:OrderedQtyUnit>
              <ns0:Product>
                <ns0:Code>
                  <xsl:value-of select=""Product/Code/text()"" />
                </ns0:Code>
              </ns0:Product>
            </ns0:OrderLine>
            </xsl:for-each>
          </ns0:OrderLineCollection>
        </ns0:Order>
        <ns0:OrganizationAddressCollection>
          <xsl:for-each select=""OrganizationAddressCollection/OrganizationAddress"">
            <ns0:OrganizationAddress>
              <ns0:AddressType>
                <xsl:value-of select=""AddressType/text()"" />
              </ns0:AddressType>
              <xsl:if test=""Address1"">
                <ns0:Address1>
                  <xsl:value-of select=""Address1/text()"" />
                </ns0:Address1>
              </xsl:if>
              <xsl:if test=""Address2"">
                <ns0:Address2>
                  <xsl:value-of select=""Address2/text()"" />
                </ns0:Address2>
              </xsl:if>
              <xsl:if test=""AddressOverride"">
                <ns0:AddressOverride>
                  <xsl:value-of select=""AddressOverride/text()"" />
                </ns0:AddressOverride>
              </xsl:if>
              <xsl:if test=""City"">
                <ns0:City>
                  <xsl:value-of select=""City/text()"" />
                </ns0:City>
              </xsl:if>
              <ns0:CompanyName>
                <xsl:value-of select=""CompanyName/text()"" />
              </ns0:CompanyName>
              <xsl:for-each select=""Country"">
                <ns0:Country>
                  <ns0:Code>
                    <xsl:value-of select=""Code/text()"" />
                  </ns0:Code>
                </ns0:Country>
              </xsl:for-each>
              <xsl:if test=""OrganizationCode"">
                <ns0:OrganizationCode>
                  <xsl:value-of select=""OrganizationCode/text()"" />
                </ns0:OrganizationCode>
              </xsl:if>
              <xsl:if test=""Postcode"">
                <ns0:Postcode>
                  <xsl:value-of select=""Postcode/text()"" />
                </ns0:Postcode>
              </xsl:if>
              <xsl:if test=""State"">
                <ns0:State>
                  <xsl:value-of select=""State/text()"" />
                </ns0:State>
              </xsl:if>
            </ns0:OrganizationAddress>
          </xsl:for-each>
        </ns0:OrganizationAddressCollection>
      </ns0:Shipment>
    </ns0:UniversalShipment>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
  public string StringConcat(string param0) { return param0; }
public string DateimeConversion(string strin) { strin = strin.Substring(0, 4) + ""-"" + strin.Substring(4, 2) + ""-"" + strin.Substring(6, 2); DateTime strdatetime = new DateTime(); strdatetime = DateTime.Parse(strin); strin = strdatetime.ToString(""yyyy-MM-ddTHH:mm:ss""); return strin; }
public bool LogicalEq(string val1, string val2) { bool ret = false; double d1 = 0; double d2 = 0; if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2)) { ret = d1 == d2; } else { ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0; } return ret; }
public string ChkSCACt(string strWO10, string strWO05) { if (strWO10 == ""FDXIP"" || strWO10 == ""FDXIE"" || strWO10 == ""FDXIG"" || strWO10 == ""FXND"" || strWO10 == ""FDEG"" || strWO10 == ""FXPO"" || strWO10 == ""FXSP"" || strWO10 == ""FDES"" || strWO10 == ""FDXES"" || strWO10 == ""FDXSO"" || strWO10 == ""FDXHD"") { return ""FEDEXPUS""; } else if (strWO10 == ""UPSG"") { return ""UPSUS2""; } else if (strWO10 == ""UPS3D"" || strWO10 == ""UPSNDS"" || strWO10 == ""UPS2D"" || strWO10 == ""UPSNDA"") { return ""UPSAIRUS""; } else if (strWO10 == ""LTL"") { return strWO05; } else { if (strWO05 != """") { return """"; } else { return strWO10; } } return """"; }
public string ChkSCAC(string strWO10, string strWO05) { if (strWO10 == ""UPS3D"" || strWO10 == ""UPSNDS"" || strWO10 == ""UPS2D"" || strWO10 == ""UPSNDA"" || strWO10 == ""UPSSG"" || strWO10 == ""FDXIP"" || strWO10 == ""FDXIE"" || strWO10 == ""FDXIG"" || strWO10 == ""FXND"" || strWO10 == ""FDEG"" || strWO10 == ""FXPO"" || strWO10 == ""FXSP"" || strWO10 == ""FDES"" || strWO10 == ""FDXES"" || strWO10 == ""FDXSO"" || strWO10 == ""FDXHD"") { return """"; } else if (strWO10 == ""LTL"") { return strWO05; } else { if (strWO10 != """") { return strWO10; } else { return strWO05; } } return """"; }
public string ChkSCACCity(string strWO10, string strWO05) { if (strWO10 != ""UPS3D"" || strWO10 != ""UPSNDS"" || strWO10 != ""UPS2D"" || strWO10 != ""UPSNDA"" || strWO10 != ""UPSSG"" || strWO10 != ""FDXIP"" || strWO10 != ""FDXIE"" || strWO10 != ""FDXIG"" || strWO10 != ""FXND"" || strWO10 != ""FDEG"" || strWO10 != ""FXPO"" || strWO10 != ""FXSP"" || strWO10 != ""FDES"" || strWO10 != ""FDXES"" || strWO10 != ""FDXSO"" || strWO10 != ""FDXHD"") { return """"; } else { if (strWO05 != """") { return """"; } } return """"; }
public string ChkSCACCountry(string strWO10, string strWO05) { if (strWO10 != ""UPS3D"" || strWO10 != ""UPSNDS"" || strWO10 != ""UPS2D"" || strWO10 != ""UPSNDA"" || strWO10 != ""UPSSG"" || strWO10 != ""FDXIP"" || strWO10 != ""FDXIE"" || strWO10 != ""FDXIG"" || strWO10 != ""FXND"" || strWO10 != ""FDEG"" || strWO10 != ""FXPO"" || strWO10 != ""FXSP"" || strWO10 != ""FDES"" || strWO10 != ""FDXES"" || strWO10 != ""FDXSO"" || strWO10 != ""FDXHD"") { return """"; } else { if (strWO05 != """") { return ""US""; } } return """"; }
public bool IsNumeric(string val) { if (val == null) { return false; } double d = 0; return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d); }
public bool IsNumeric(string val, ref double d) { if (val == null) { return false; } return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d); }
  ]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.Cargowiseone.StyleOne.StyleOne_Input";
        
        private const global::GLC.Integration.Cargowiseone.StyleOne.StyleOne_Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.Cargowiseone.StyleOne.StyleOne_Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _TrgSchemas;
            }
        }
    }
}
