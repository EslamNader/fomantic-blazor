﻿using Fomantic.Blazor.UI;
using Microsoft.AspNetCore.Components;

namespace Fomantic
{

    /// <summary>
    /// Base interface for all fomantic component that can have loading indecator in it 
    /// </summary>
    public interface IFomanticComponentWithLoadingIndicator : IFomanticComponentWithClass
    {
        /// <summary>
        /// class given to make component appear as loading
        /// </summary>
        const string LoadingClass = "loading";

        /// <summary>
        /// Determine if the component should be appear as loading or not
        /// </summary>
        [Parameter]
        bool IsLoading { get; set; }
    }
}
