using StringSorter.Scripts.Sortables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorter.Scripts;

public class SortController
{
    private static SortController instance;

    public static SortController Instance => instance;

    private SortModel _model;
    private frmMain _view;

    private ISortable _sortable;

    public SortController(SortModel model, frmMain view) 
    {
        instance = this;
        _model = model;
        _view = view;
    }

    public void Sorted()
    {
        _model.InputString = _view.GetInputString();
        SortType strategy = _view.GetSelectedSortType();

        switch (strategy)
        {
            case SortType.Bubble:
                _sortable = new BubbleSort();
                break;
            case SortType.Quick:
                _sortable = new QuickSort();
                break;
            case SortType.Merge:
                _sortable = new MergeSort();
                break;
        }

        _model.SortedString = _sortable.SortBy(_model.InputString);
        _view.DisplaySortedString(_model.SortedString);
    }
}
