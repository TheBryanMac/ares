//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RasterEditor {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "Raster Editor";
            }
        }
        
        internal static string AddInID {
            get {
                return "{188f12a1-059d-43c7-873d-366c48ee625f}";
            }
        }
        
        internal static string Company {
            get {
                return "Haoliang Yu";
            }
        }
        
        internal static string Version {
            get {
                return "1.1.5408";
            }
        }
        
        internal static string Description {
            get {
                return @"This tool aims at extending the raster editing function of ArcMap. With the new Raster Editor toolbar, users are able to edit the raster layer in an interactive manner, just like what users can do with the feature layer. Find more guide and detail at https://sourceforge.net/projects/arcmaprastereditor/. ";
            }
        }
        
        internal static string Author {
            get {
                return "Haoliang Yu";
            }
        }
        
        internal static string Date {
            get {
                return "10/22/2014";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'RasterEditor_IdentifyTool', the id declared for Add-in Tool class 'IdentifyTool'
            /// </summary>
            internal static string IdentifyTool {
                get {
                    return "RasterEditor_IdentifyTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_LayerComboBox', the id declared for Add-in ComboBox class 'LayerComboBox'
            /// </summary>
            internal static string LayerComboBox {
                get {
                    return "RasterEditor_LayerComboBox";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_StartEditingButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.Edition.StartEditingButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_Edition_StartEditingButton {
                get {
                    return "RasterEditor_StartEditingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_StopEditingButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.Edition.StopEditingButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_Edition_StopEditingButton {
                get {
                    return "RasterEditor_StopEditingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_SaveEditsButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.Edition.SaveEditsButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_Edition_SaveEditsButton {
                get {
                    return "RasterEditor_SaveEditsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_OptionButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.OptionButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_OptionButton {
                get {
                    return "RasterEditor_OptionButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_ShowEditsButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.ShowEditsButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_ShowEditsButton {
                get {
                    return "RasterEditor_ShowEditsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_SelectTool', the id declared for Add-in Tool class 'SelectTool'
            /// </summary>
            internal static string SelectTool {
                get {
                    return "RasterEditor_SelectTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_Debug', the id declared for Add-in Button class 'Debug'
            /// </summary>
            internal static string Debug {
                get {
                    return "RasterEditor_Debug";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_SaveEditsAsButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.Edition.SaveEditsAsButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_Edition_SaveEditsAsButton {
                get {
                    return "RasterEditor_SaveEditsAsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_GoToPixelTool', the id declared for Add-in Button class 'GoToPixelTool'
            /// </summary>
            internal static string GoToPixelTool {
                get {
                    return "RasterEditor_GoToPixelTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_EditExtentButon', the id declared for Add-in Button class 'RasterEditor.EditorMenu.Tools.EditExtentButon'
            /// </summary>
            internal static string RasterEditor_EditorMenu_Tools_EditExtentButon {
                get {
                    return "RasterEditor_EditExtentButon";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_RefreshButton', the id declared for Add-in Button class 'RasterEditor.EditorMenu.RefreshButton'
            /// </summary>
            internal static string RasterEditor_EditorMenu_RefreshButton {
                get {
                    return "RasterEditor_RefreshButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_IdentifyForm', the id declared for Add-in DockableWindow class 'RasterEditor.Forms.IdentifyForm+AddinImpl'
            /// </summary>
            internal static string RasterEditor_Forms_IdentifyForm {
                get {
                    return "RasterEditor_IdentifyForm";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_EditForm', the id declared for Add-in DockableWindow class 'RasterEditor.Forms.EditForm+AddinImpl'
            /// </summary>
            internal static string RasterEditor_Forms_EditForm {
                get {
                    return "RasterEditor_EditForm";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
