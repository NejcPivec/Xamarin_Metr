//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Metrel.TreePage.xaml", "TreePage.xaml", typeof(global::Metrel.TreePage))]

namespace Metrel {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("TreePage.xaml")]
    public partial class TreePage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Metrel.FileManagerViewModel viewModel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.XForms.TreeView.SfTreeView treeView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(TreePage));
            viewModel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Metrel.FileManagerViewModel>(this, "viewModel");
            treeView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.XForms.TreeView.SfTreeView>(this, "treeView");
        }
    }
}