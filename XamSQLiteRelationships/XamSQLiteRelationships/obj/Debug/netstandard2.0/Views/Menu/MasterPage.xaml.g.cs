//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("XamSQLiteRelationships.Views.Menu.MasterPage.xaml", "Views/Menu/MasterPage.xaml", typeof(global::XamSQLiteRelationships.Views.Menu.Menu))]

namespace XamSQLiteRelationships.Views.Menu {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Menu\\MasterPage.xaml")]
    public partial class Menu : global::Xamarin.Forms.MasterDetailPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.RowDefinition ProfileRow;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout Profile;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout profileDetail;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Menu));
            ProfileRow = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.RowDefinition>(this, "ProfileRow");
            Profile = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "Profile");
            profileDetail = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "profileDetail");
        }
    }
}