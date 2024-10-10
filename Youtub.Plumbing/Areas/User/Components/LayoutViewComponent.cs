using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace YouTube.Plumbing.Areas.User.Components
{
    [Authorize]
    [Area("User")]
    public class LayoutViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public LayoutViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            // Check if 'id' is null and attempt to retrieve it from claims
            if (id == null)
            {
                var identifierClaim = UserClaimsPrincipal.Claims.FirstOrDefault(x => x.Type.Contains("identifier"));
                if (identifierClaim == null)
                {
                    // Handle the case where the identifier claim is missing
                    throw new InvalidOperationException("User identifier claim is missing.");
                }
                id = identifierClaim.Value;
            }

            // Attempt to find the user by ID
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                // Handle the case where the user is not found
                throw new InvalidOperationException("User not found.");
            }

            // Return a view with either the user's FileName or a default value
            return View(new UserPictureVM { FileName = user.FileName ?? "Default" });
        }

    }
}
