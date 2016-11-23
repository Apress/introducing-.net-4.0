using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Xml.Linq;

namespace Chapter03.DLR
{
    public class EasierXML : DynamicObject
    {
        private XDocument _xml = new XDocument();

        public EasierXML(string Xml)
        {
            this._xml = XDocument.Parse(Xml);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string nodeName = binder.Name;
            result = _xml.Element("test").Element(nodeName).Value;
            return true;
        }
    }
}