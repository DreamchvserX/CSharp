using System;
using System.Windows;
using System.Windows.Controls;

namespace DataApplication
{
    
    public class AlternatingStyleSelector : StyleSelector
    {
        private Style itemStyle = null;
        private Style alternateItemStyle = null;

        public Style ItemStyle
        {
            get
            {
                return itemStyle;
            }
            set
            {
                itemStyle = value;
            }
        }

        public Style AlternateItemStyle
        {
            get
            {
                return alternateItemStyle;
            }
            set
            {
                alternateItemStyle = value;
            }
        }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            int index = itemsControl.ItemContainerGenerator.IndexFromContainer(container);
            return (index % 2 == 0 ? itemStyle : alternateItemStyle);
        }
    }

}
