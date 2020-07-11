using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using WPF_Infrostruktura_TK_test_task.Models;

namespace WPF_Infrostruktura_TK_test_task.ViewModels
{
    class VariableViewModels: DependencyObject
    {

        public string FilterGroup
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterVariables.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterVariables", typeof(string), typeof(VariableViewModels), new PropertyMetadata("",FilterGroup_Changed));

        private static void FilterGroup_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VariableViewModels current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Group;
            }
        }

        public string FilterName
        {
            get { return (string)GetValue(FilterNameProperty); }
            set { SetValue(FilterNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterNameProperty =
            DependencyProperty.Register("FilterName", typeof(string), typeof(VariableViewModels), new PropertyMetadata("", FilterName_Changed));

        private static void FilterName_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VariableViewModels current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Name;
            }
        }



        public string FilterDescription
        {
            get { return (string)GetValue(FilterDescriptionProperty); }
            set { SetValue(FilterDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterDescriptionProperty =
            DependencyProperty.Register("FilterDescription", typeof(string), typeof(VariableViewModels), new PropertyMetadata("",FilterDescription_Changed));

        private static void FilterDescription_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VariableViewModels current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Description;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(VariableViewModels), new PropertyMetadata(null));

        public VariableViewModels()
        {
            Items = CollectionViewSource.GetDefaultView(Variable.GetVariables());
            Items.Filter = FilterVariables_by_Group; 
        }

        private bool FilterVariables_by_Group(object obj)
        {
            return !string.IsNullOrEmpty(FilterGroup) && obj is Variable_with_group current_var_with_gr && !current_var_with_gr.Group.Contains(FilterGroup) ? false : true;
        }
        private bool FilterVariables_by_Name(object obj)
        {
           return !string.IsNullOrEmpty(FilterName) && obj is Variable_with_group current_var_with_gr && !current_var_with_gr.Name.Contains(FilterName) ? false : true;
        }
        private bool FilterVariables_by_Description(object obj)
        {
            return !string.IsNullOrEmpty(FilterDescription) && obj is Variable_with_group current_var_with_gr && !current_var_with_gr.Description.Contains(FilterDescription) ? false : true;
        }
    }
}
