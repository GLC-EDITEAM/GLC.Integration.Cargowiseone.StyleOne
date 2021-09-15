using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System.IO;
using System.Xml;


namespace GLC.Integration.Cargowiseone.StyleOne.PipelineComp
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("B83AE1BA-F218-4557-A46B-51921C2A6A6B")]
    public class Change_Namespace : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "styleone_change_namespace"; }
        }

        /// <summary>
        /// Version of the component.
        /// </summary>
        //[Browsable(false)]
        public string Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// Description of the component.
        /// </summary>
        // [Browsable(false)]
        public string Description
        {
            get { return "Change Namespace styleone"; }
        }

        #endregion
        #region IComponentUI
        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }

        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }
        #endregion
        #region IComponent

        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {
            var shipcode = new List<string>();
            var ponum = new List<string>();
            IBaseMessageContext messageContext = inmsg.Context;
            Stream originalStream = inmsg.BodyPart.GetOriginalDataStream();
            StreamReader strmread = new StreamReader(originalStream);
            string data = strmread.ReadToEnd();
            data = data.Replace(@"<UniversalShipment>", "<ns0:UniversalShipment xmlns:ns0=\"http://www.cargowise.com/Schemas/Universal/2011/11\">");
            data = data.Replace(@"</UniversalShipment>", "</ns0:UniversalShipment>");
            data = data.Replace("<?xml version=\"1.0\" encoding=\"UTF-16\"?>", "<?xml version=\"1.0\"?>");
            int n = 1;
            string[] lines = data.Split(Environment.NewLine.ToCharArray()).Skip(n).ToArray();
            string op = string.Join(Environment.NewLine, lines);
            op = op.TrimStart();
            byte[] bytearray = Encoding.ASCII.GetBytes(op);
            MemoryStream streamconv = new MemoryStream(bytearray);
            originalStream = streamconv;
            originalStream.Seek(0, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalStream;
            inmsg.Context = messageContext;
            return inmsg;
        }
        #endregion

    }
}

