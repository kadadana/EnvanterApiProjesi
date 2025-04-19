using X.PagedList;

namespace EnvanterApiProjesi.Models;
public class EnvanterViewModel
{
    public EnvanterModel? SelectedComputer { get; set; }
    public IPagedList<EnvanterModel>? EnvanterList { get; set; }
    public List<DriveInfoModel>? SelectedDisks { get; set; }
}