// Updated by XamlIntelliSenseFileGenerator 27.02.2022 23:18:24
#pragma checksum "..\..\PageEmploye.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20C739E66DAE91CBA26DC2B0306929DFEE5D5FF04D6633186BEF41000A76ECD5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp1;
using WpfApp1.Commands;
using WpfApp1.Model;
using WpfApp1.ValidationRules;


namespace WpfApp1
{


    /// <summary>
    /// PageEmploye
    /// </summary>
    public partial class PageEmploye : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 66 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar TooBar1;

#line default
#line hidden


#line 67 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;

#line default
#line hidden


#line 70 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;

#line default
#line hidden


#line 73 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;

#line default
#line hidden


#line 76 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Find;

#line default
#line hidden


#line 79 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;

#line default
#line hidden


#line 82 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;

#line default
#line hidden


#line 87 "..\..\PageEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmpoyee;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pageemploye.xaml", System.UriKind.Relative);

#line 1 "..\..\PageEmploye.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\PageEmploye.xaml"
                    ((WpfApp1.PageEmploye)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);

#line default
#line hidden
                    return;
                case 2:

#line 43 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UndoCommandBinding_Executed);

#line default
#line hidden

#line 43 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UndoCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 3:

#line 44 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandBinding_Executed);

#line default
#line hidden

#line 44 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 4:

#line 45 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.FindCommandBinding_Executed);

#line default
#line hidden

#line 45 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.FindCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 5:

#line 46 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddCommandBinding_executed);

#line default
#line hidden

#line 46 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AddCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 6:

#line 48 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCommandBinding_Executed);

#line default
#line hidden

#line 48 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 7:

#line 49 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteCommandBinding_Executed);

#line default
#line hidden

#line 49 "..\..\PageEmploye.xaml"
                    ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.DeleteCommandBinding_CanExecute);

#line default
#line hidden
                    return;
                case 8:
                    this.TooBar1 = ((System.Windows.Controls.ToolBar)(target));
                    return;
                case 9:
                    this.Undo = ((System.Windows.Controls.Button)(target));
                    return;
                case 10:
                    this.Add = ((System.Windows.Controls.Button)(target));
                    return;
                case 11:
                    this.Edit = ((System.Windows.Controls.Button)(target));
                    return;
                case 12:
                    this.Find = ((System.Windows.Controls.Button)(target));
                    return;
                case 13:
                    this.Save = ((System.Windows.Controls.Button)(target));
                    return;
                case 14:
                    this.Delete = ((System.Windows.Controls.Button)(target));
                    return;
                case 15:
                    this.DataGridEmpoyee = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 16:
                    this.BorderFind = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 17:
                    this.TextBlockSurname = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 18:
                    this.TextBlockTitle = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 19:
                    this.TextBoxSurname = ((System.Windows.Controls.TextBox)(target));

#line 192 "..\..\PageEmploye.xaml"
                    this.TextBoxSurname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxSurname_TextChanged);

#line default
#line hidden
                    return;
                case 20:
                    this.ComboBoxTitle = ((System.Windows.Controls.ComboBox)(target));

#line 194 "..\..\PageEmploye.xaml"
                    this.ComboBoxTitle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxTitle_SelectionChanged);

#line default
#line hidden
                    return;
                case 21:
                    this.ButtonFindSurname = ((System.Windows.Controls.Button)(target));

#line 195 "..\..\PageEmploye.xaml"
                    this.ButtonFindSurname.Click += new System.Windows.RoutedEventHandler(this.ButtonFindSurname_Click);

#line default
#line hidden
                    return;
                case 22:
                    this.ButtonFindTitle = ((System.Windows.Controls.Button)(target));

#line 198 "..\..\PageEmploye.xaml"
                    this.ButtonFindTitle.Click += new System.Windows.RoutedEventHandler(this.ButtonFindTitle_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock TextBlockSurname;
        internal System.Windows.Controls.TextBlock TextBlockTitle;
        internal System.Windows.Controls.TextBox TextBoxSurname;
        internal System.Windows.Controls.ComboBox ComboBoxTitle;
        internal System.Windows.Controls.Button ButtonFindSurname;
        internal System.Windows.Controls.Button ButtonFindTitle;
        internal System.Windows.Controls.Grid BorderFind;
    }
}

