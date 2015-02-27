

using UnityEngine;


//
// Autogenerated by gaxb ( https://github.com/SmallPlanet/gaxb )
//

using System;
using System.Xml;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;


public partial class PUObject : PUObjectBase {
	
	public PUObject()
	{
	}
	
	
	public PUObject(
			string title,
			string tag,
			string tag1,
			string tag2,
			string tag3,
			string tag4,
			string tag5,
			string tag6 ) : this()
	{
		this.title = title;

		this.tag = tag;

		this.tag1 = tag1;

		this.tag2 = tag2;

		this.tag3 = tag3;

		this.tag4 = tag4;

		this.tag5 = tag5;

		this.tag6 = tag6;
	}

	

}




public class PUObjectBase : IPlanetUnity2 {


	private static Type planetOverride = Type.GetType("PlanetUnityOverride");
	private static MethodInfo processStringMethod = planetOverride.GetMethod("processString", BindingFlags.Public | BindingFlags.Static);


	public object parent;
	public string xmlns = "http://schema.smallplanet.com/PlanetUnity2";


	// XML Attributes
	public string title;
	public string tag;
	public string tag1;
	public string tag2;
	public string tag3;
	public string tag4;
	public string tag5;
	public string tag6;



	// XML Sequences
	public List<object> children = new List<object>();
	


	public virtual void gaxb_unload()
	{

	}
	
	public void gaxb_addToParent()

	{
		if(parent != null)
		{
			FieldInfo parentField = parent.GetType().GetField("Object");
			List<object> parentChildren = null;
			
			if(parentField != null)
			{
				parentField.SetValue(parent, this);
			}
			else
			{
				parentField = parent.GetType().GetField("Objects");
				
				if(parentField != null)
				{
					parentChildren = (List<object>)(parentField.GetValue(parent));
				}
				else
				{
					parentField = parent.GetType().GetField("PlanetUnity2s");
					if(parentField != null)
					{
						parentChildren = (List<object>)(parentField.GetValue(parent));
					}
				}
				if(parentChildren == null)
				{
					FieldInfo childrenField = parent.GetType().GetField("children");
					if(childrenField != null)
					{
						parentChildren = (List<object>)childrenField.GetValue(parent);
					}
				}
				if(parentChildren != null)
				{
					parentChildren.Add(this);
				}
				
			}
		}
	}

	public virtual void gaxb_load(XmlReader reader, object _parent, Hashtable args)
	{

		if(reader == null && _parent == null)
			return;
		
		parent = _parent;
		
		if(this.GetType() == typeof( PUObject ))
		{
			gaxb_addToParent();
		}
		
		xmlns = reader.GetAttribute("xmlns");
		

		string attr;
		attr = reader.GetAttribute("title");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { title = attr; } 
		
		attr = reader.GetAttribute("tag");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag = attr; } 
		
		attr = reader.GetAttribute("tag1");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag1 = attr; } 
		
		attr = reader.GetAttribute("tag2");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag2 = attr; } 
		
		attr = reader.GetAttribute("tag3");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag3 = attr; } 
		
		attr = reader.GetAttribute("tag4");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag4 = attr; } 
		
		attr = reader.GetAttribute("tag5");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag5 = attr; } 
		
		attr = reader.GetAttribute("tag6");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { tag6 = attr; } 
		

	}
	
	
	
	
	
	
	
	public virtual void gaxb_appendXMLAttributes(StringBuilder sb)
	{

		if(title != null) { sb.AppendFormat (" {0}=\"{1}\"", "title", title); }
		if(tag != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag", tag); }
		if(tag1 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag1", tag1); }
		if(tag2 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag2", tag2); }
		if(tag3 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag3", tag3); }
		if(tag4 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag4", tag4); }
		if(tag5 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag5", tag5); }
		if(tag6 != null) { sb.AppendFormat (" {0}=\"{1}\"", "tag6", tag6); }

	}
	
	public virtual void gaxb_appendXMLSequences(StringBuilder sb)
	{

		MethodInfo mInfo;		foreach(object o in children) { mInfo = o.GetType().GetMethod("gaxb_appendXML"); if(mInfo != null) { mInfo.Invoke (o, new[] { sb }); } else { sb.AppendFormat ("<{0}>{1}</{0}>", "any", o); } }
	

	}
	
	public virtual void gaxb_appendXML(StringBuilder sb)
	{
		if(sb.Length == 0)
		{
			sb.AppendFormat ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		
		sb.AppendFormat ("<{0}", "Object");
		
		if(xmlns != null) {
			if(parent == null) {
				sb.AppendFormat (" {0}=\"{1}\"", "xmlns", xmlns);
			}else{
				FieldInfo parentField = parent.GetType().GetField("xmlns");
				if(parentField != null && xmlns.Equals(parentField.GetValue(parent)) == false)
				{
					sb.AppendFormat (" {0}=\"{1}\"", "xmlns", xmlns);
				}
			}
		}
		
		gaxb_appendXMLAttributes(sb);
		
		
		StringBuilder seq = new StringBuilder();
		seq.AppendFormat(" ");
		gaxb_appendXMLSequences(seq);
		
		if(seq.Length == 1)
		{
			sb.AppendFormat (" />");
		}
		else
		{
			sb.AppendFormat (">{0}</{1}>", seq.ToString(), "Object");
		}
	}
}
