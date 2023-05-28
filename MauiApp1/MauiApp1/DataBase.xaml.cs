using MauiApp1.Entities;
using MauiApp1.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiApp1;

public partial class DataBase : ContentPage
{
    public DataBase(IDbService db)
    {
        InitializeComponent();
        BindingContext = this;
        local_db = db;
        RegionsList.Clear();
        foreach (var item in local_db.GetAllRegions())
        {
            RegionsList.Add(item);
        }
    }

    private IDbService local_db = null;

    public ObservableCollection<Entities.Region> RegionsList { get; set; } = new ObservableCollection<Entities.Region>();
    public ObservableCollection<City> Cities { get; set; } = new ObservableCollection<City>();


    private Entities.Region _selectedRegion;
    public Entities.Region SelectedRegion
    {

        get => _selectedRegion;
        set
        {
            Cities.Clear();
            foreach (var city in local_db.GetCities(value.Name))
            {
                Cities.Add(city);
            }
            _selectedRegion = value;
        }
    }
}