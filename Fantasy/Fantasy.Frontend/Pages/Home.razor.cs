//using Fantasy.Frontend.Resources;
using Fantasy.Shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace Fantasy.Frontend.Pages;

public partial class Home
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;

    private bool arrows = true;
    private bool bullets = true;
    private bool enableSwipeGesture = true;
    private bool autocycle = true;
    private Transition transition = Transition.Slide;
}