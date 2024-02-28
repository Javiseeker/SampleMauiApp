using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ViewModels;

[ObservableRecipient]
public partial class FromScratchViewModel: ObservableObject, INotifyPropertyChanged
{
    #region MAUI Community Toolkit
    [ObservableProperty]
    private ObservableCollection<string> collectionBindedWithToolkit;

    #endregion

    #region MAUI Native Data Binding with MVVM
    private ObservableCollection<string> _collectionBindedNatively;
    public ObservableCollection<string> CollectionBindedNatively
    {
        get => _collectionBindedNatively;
        set
        {
            if (_collectionBindedNatively != value)
            {
                _collectionBindedNatively = value;
                OnPropertyChanged(nameof(CollectionBindedNatively));
            }
        }
    }

    // both the ObservableObject and INotifyPropertyChanged require this PropertyChanged.
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    public FromScratchViewModel()
    {
        CollectionBindedNatively = new();
        CollectionBindedWithToolkit = new();
    }
    public async Task InitializeView()
    {
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            CollectionBindedNatively.Add("Test");
            CollectionBindedNatively.Add("Test2");
            CollectionBindedNatively.Add("Test3");
            CollectionBindedNatively.Add("Test4");

            CollectionBindedWithToolkit.Add("Test");
            CollectionBindedWithToolkit.Add("Test2");
            CollectionBindedWithToolkit.Add("Test3");
            CollectionBindedWithToolkit.Add("Test4");
        });
    }

    public async Task PushToCV()
    {
        Random rand = new Random();
        var valueToAdd = rand.Next(5, 100);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            CollectionBindedNatively.Add($"TRad{valueToAdd}");
            CollectionBindedWithToolkit.Add($"TRad{valueToAdd}");
        });
    }

    public async Task PopFromCV()
    {
        if (CollectionBindedNatively.Any())
            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                CollectionBindedNatively.RemoveAt(CollectionBindedNatively.Count - 1);
                CollectionBindedWithToolkit.RemoveAt(CollectionBindedNatively.Count - 1);
            });
    }
}
