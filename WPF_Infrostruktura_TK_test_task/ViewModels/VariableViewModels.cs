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
        public string FilterName
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterVariables.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterVariables", typeof(string), typeof(VariableViewModels), new PropertyMetadata("",FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as VariableViewModels;
            if (current !=null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Group;
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
            Variable_with_group current_var_with_gr = obj as Variable_with_group;

            if (!string.IsNullOrEmpty(FilterGroup) && current_var_with_gr!= null && !current_var_with_gr.Group.Contains(FilterGroup))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
