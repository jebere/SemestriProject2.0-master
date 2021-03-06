﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Pages.AirFreight;

namespace SemestriProject.Soft.Areas.AirFreight.Pages.China
{
    public class EditModel : ChinaPage
    {
        public EditModel(IChinaRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }

}
