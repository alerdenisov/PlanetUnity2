

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


public partial class PUSlider : PUSliderBase {
	
	public PUSlider()
	{
		string attr;

		attr = "32,32";
		if(attr != null) { handleSize = new Vector2().PUParse(attr); } 
		attr = "0";
		if(attr != null) { minValue = float.Parse(attr); } 
		attr = "1";
		if(attr != null) { maxValue = float.Parse(attr); } 

	}
	
	
	public PUSlider(
			string handleResourcePath,
			Vector2 handleSize,
			string fillResourcePath,
			string onValueChanged,
			float minValue,
			float maxValue,
			PlanetUnity2.SliderDirection direction,
			string resourcePath ) : this()
	{
		this.handleResourcePath = handleResourcePath;

		this.handleSize = handleSize;

		this.fillResourcePath = fillResourcePath;

		this.onValueChanged = onValueChanged;

		this.minValue = minValue;

		this.maxValue = maxValue;

		this.direction = direction;

		this.resourcePath = resourcePath;
	}

	
	
	public PUSlider(
			string handleResourcePath,
			Vector2 handleSize,
			string fillResourcePath,
			string onValueChanged,
			float minValue,
			float maxValue,
			PlanetUnity2.SliderDirection direction,
			string resourcePath,
			Color color,
			PlanetUnity2.ImageType type,
			Vector4 bounds,
			Vector3 position,
			Vector2 size,
			Vector3 rotation,
			Vector3 scale,
			Vector2 pivot,
			string anchor,
			bool active,
			bool mask,
			Vector4 maskInset,
			bool outline,
			float lastY,
			float lastX,
			string shader,
			bool ignoreMouse,
			string components,
			string title,
			string tag,
			string tag1,
			string tag2,
			string tag3,
			string tag4,
			string tag5,
			string tag6 ) : this()
	{
		this.handleResourcePath = handleResourcePath;

		this.handleSize = handleSize;

		this.fillResourcePath = fillResourcePath;

		this.onValueChanged = onValueChanged;

		this.minValue = minValue;

		this.maxValue = maxValue;

		this.direction = direction;

		this.resourcePath = resourcePath;

		this.color = color;

		this.type = type;

		this.bounds = bounds;

		this.position = position;

		this.size = size;

		this.rotation = rotation;

		this.scale = scale;

		this.pivot = pivot;

		this.anchor = anchor;

		this.active = active;

		this.mask = mask;

		this.maskInset = maskInset;

		this.outline = outline;

		this.lastY = lastY;

		this.lastX = lastX;

		this.shader = shader;

		this.ignoreMouse = ignoreMouse;

		this.components = components;

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




public class PUSliderBase : PUImage {






	// XML Attributes
	public string handleResourcePath;
	public Vector2? handleSize;
	public string fillResourcePath;
	public string onValueChanged;
	public float? minValue;
	public float? maxValue;
	public PlanetUnity2.SliderDirection? direction;




	public override void gaxb_unload()
	{
		base.gaxb_unload();

	}
	
	public new void gaxb_addToParent()

	{
		if(parent != null)
		{
			FieldInfo parentField = parent.GetType().GetField("Slider");
			List<object> parentChildren = null;
			
			if(parentField != null)
			{
				parentField.SetValue(parent, this);
			}
			else
			{
				parentField = parent.GetType().GetField("Sliders");
				
				if(parentField != null)
				{
					parentChildren = (List<object>)(parentField.GetValue(parent));
				}
				else
				{
					parentField = parent.GetType().GetField("Images");
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

	public override void gaxb_load(XmlReader reader, object _parent, Hashtable args)
	{
		base.gaxb_load(reader, _parent, args);

		if(reader == null && _parent == null)
			return;
		
		parent = _parent;
		
		if(this.GetType() == typeof( PUSlider ))
		{
			gaxb_addToParent();
		}
		
		xmlns = reader.GetAttribute("xmlns");
		

		string attr;
		attr = reader.GetAttribute("handleResourcePath");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr != null) { handleResourcePath = attr; } 
		
		attr = reader.GetAttribute("handleSize");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr == null) { attr = "32,32"; }
		if(attr != null) { handleSize = new Vector2().PUParse(attr); } 
		
		attr = reader.GetAttribute("fillResourcePath");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr != null) { fillResourcePath = attr; } 
		
		attr = reader.GetAttribute("onValueChanged");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr != null) { onValueChanged = attr; } 
		
		attr = reader.GetAttribute("minValue");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr == null) { attr = "0"; }
		if(attr != null) { minValue = float.Parse(attr); } 
		
		attr = reader.GetAttribute("maxValue");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr == null) { attr = "1"; }
		if(attr != null) { maxValue = float.Parse(attr); } 
		
		attr = reader.GetAttribute("direction");
		if(attr != null) { attr = PlanetUnityOverride.processString(_parent, attr); }
		if(attr != null) { direction = (PlanetUnity2.SliderDirection)Enum.Parse(typeof(PlanetUnity2.SliderDirection), attr); } 
		

	}
	
	
	
	
	
	
	
	public override void gaxb_appendXMLAttributes(StringBuilder sb)
	{
		base.gaxb_appendXMLAttributes(sb);

		if(handleResourcePath != null) { sb.AppendFormat (" {0}=\"{1}\"", "handleResourcePath", handleResourcePath); }
		if(handleSize != null) { sb.AppendFormat (" {0}=\"{1}\"", "handleSize", handleSize.Value.PUToString()); }
		if(fillResourcePath != null) { sb.AppendFormat (" {0}=\"{1}\"", "fillResourcePath", fillResourcePath); }
		if(onValueChanged != null) { sb.AppendFormat (" {0}=\"{1}\"", "onValueChanged", onValueChanged); }
		if(minValue != null) { sb.AppendFormat (" {0}=\"{1}\"", "minValue", minValue.Value.ToString ("0.##")); }
		if(maxValue != null) { sb.AppendFormat (" {0}=\"{1}\"", "maxValue", maxValue.Value.ToString ("0.##")); }
		if(direction != null) { sb.AppendFormat (" {0}=\"{1}\"", "direction", (int)direction); }

	}
	
	public override void gaxb_appendXMLSequences(StringBuilder sb)
	{
		base.gaxb_appendXMLSequences(sb);


	}
	
	public override void gaxb_appendXML(StringBuilder sb)
	{
		if(sb.Length == 0)
		{
			sb.AppendFormat ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		
		sb.AppendFormat ("<{0}", "Slider");
		
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
			sb.AppendFormat (">{0}</{1}>", seq.ToString(), "Slider");
		}
	}
}
