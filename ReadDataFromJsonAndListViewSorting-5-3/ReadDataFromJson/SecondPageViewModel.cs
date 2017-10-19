using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ReadDataFromJson
{
	public class SecondPageViewModel : ViewModelBase
	{
		public MyJsseResponse.RootObjectJSSE _selecteJSSEObject;


		public List<RegionsResponceData> RootObjectSe => rootObjectSe;
		List<RegionsResponceData> rootObjectSe = new List<RegionsResponceData>();


		RegionsResponceData selectedMajorGroup;
		public RegionsResponceData SelectedMajorGroup
		{
			get { return selectedMajorGroup; }
			set
			{
				if (selectedMajorGroup != value)
				{
					selectedMajorGroup = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedMajorGroup");
				}
			}
		}


		public SecondPageViewModel(MyJsseResponse.RootObjectJSSE selecteJSSEObject)
		{
			_selecteJSSEObject = selecteJSSEObject;
			firstLabel = selecteJSSEObject.Observer.FullName;
			SecondLabel = selecteJSSEObject.JSSEEnteredBy;
            SelectedDate = selecteJSSEObject.CreatedDate;

			var assembly = typeof(ReadDataViewModel).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("ReadDataFromJson.Regionsdata.json");

			using (var reader = new System.IO.StreamReader(stream))
			{
				var json = reader.ReadToEnd();
				List<RegionsResponceData> data = JsonConvert.DeserializeObject<List<RegionsResponceData>>(json);
				rootObjectSe = data;
			}

            RegionsResponceData obj = new RegionsResponceData();
            obj.RegionName = selecteJSSEObject.Region;
            obj.Region_ID = selecteJSSEObject.Region_ID;
            selectedMajorGroup = obj;
            SelectedPickerTitle = selecteJSSEObject.Region;
            OnPropertyChanged("SelectedMajorGroup");
            SelectedPickerIndex = 3;

			

		}

        int selectedPickerIndex;
		public int SelectedPickerIndex
		{
			get { return selectedPickerIndex; }
			set
			{
				if (selectedPickerIndex != value)
				{
					selectedPickerIndex = value;
					OnPropertyChanged("SelectedPickerIndex");
				}
			}
		}

		string selectedPickerTitle;
		public string SelectedPickerTitle
		{
			get { return selectedPickerTitle; }
			set
			{
				if (selectedPickerTitle != value)
				{
					selectedPickerTitle = value;
					OnPropertyChanged("SelectedPickerTitle");
				}
			}
		}


		string firstLabel;
		public string FirstLabel
		{
			get { return firstLabel; }
			set
			{
				if (firstLabel != value)
				{
					firstLabel = value;
					OnPropertyChanged("FirstLabel");
				}
			}
		}

        DateTime selectedDate;
		public DateTime SelectedDate
		{
			get { return selectedDate; }
			set
			{
				if (selectedDate != value)
				{
					selectedDate = value;
					OnPropertyChanged("SelectedDate");
				}
			}
		}

		string secondLabel;
		public string SecondLabel
		{
			get { return secondLabel; }
			set
			{
				if (secondLabel != value)
				{
					secondLabel = value;
					OnPropertyChanged("SecondLabel");
				}
			}
		}
	}
}
