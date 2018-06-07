using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensiveQuesting.EnumDescription {
  /// <summary>
  /// 
  /// </summary>
  public class Description : Attribute {

    /// <summary>
    /// 
    /// </summary>
    public string Text;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Text"></param>
    public Description(string Text) {
      this.Text = Text;
    }

    /// <summary>
    /// Get the custom set name of an enum-member
    /// </summary>
    /// <param name="en">Enum-Member</param>
    /// <returns>Name of enum-member</returns>
    public static string GetDescription(Enum en) {
      Type enType = en.GetType();
      MemberInfo[] memInfo = enType.GetMember(en.ToString());

      if(memInfo != null && memInfo.Length > 0) {
        object[] attributes = memInfo[0].GetCustomAttributes(typeof(Description), false);

        if (attributes != null && attributes.Length > 0) {
          return ((Description)attributes[0]).Text;
        }
      }
      return en.ToString();
    }
  }
  
}
