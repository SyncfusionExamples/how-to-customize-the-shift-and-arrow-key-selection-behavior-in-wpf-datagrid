using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public class GridCellTextBoxRendererExt : GridCellTextBoxRenderer
    {

        public SfDataGrid grid;

        public GridCellTextBoxRendererExt(SfDataGrid sfDataGrid)

        {
            grid = sfDataGrid;
        }

        public override void OnInitializeEditElement(DataColumnBase dataColumn, TextBox uiElement, object dataContext)
        {
            base.OnInitializeEditElement(dataColumn, uiElement, dataContext);

            uiElement.PreviewKeyDown += UiElement_PreviewKeyDown;
        }

        private void UiElement_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.RightShift) || Keyboard.IsKeyDown(Key.LeftShift))
            {
                if (e.Key == Key.Right)
                {
                    grid.SelectionController.CurrentCellManager.EndEdit();
                    RowColumnIndex rowcol = new RowColumnIndex(this.grid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.RowIndex, this.grid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.ColumnIndex + 1);
                    grid.MoveCurrentCell(rowcol, false);
                }
                else if (e.Key == Key.Left)
                {
                    grid.SelectionController.CurrentCellManager.EndEdit();
                    RowColumnIndex rowcol = new RowColumnIndex(this.grid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.RowIndex, this.grid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.ColumnIndex - 1);
                    grid.MoveCurrentCell(rowcol, false);
                }

                e.Handled = true;
            }
        }
    }
}
