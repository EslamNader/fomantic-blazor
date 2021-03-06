﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Timers;
using Fomantic.Blazor.UI;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Fomantic
{

    /// <summary>
    /// A text is used to style some inline text with a simple color
    /// </summary>
    ///  <remarks>
    ///  <para>Reference : </para>
    /// <para><see href="https://fomantic-ui.com/elements/text.html">https://fomantic-ui.com/elements/text.html</see></para>
    /// </remarks>
    public abstract class TextBase : FomanticComponentWithContentBase,
        IFomanticComponentWithColor,
        IFomanticComponentWithSize,
        IFomanticComponentCanBeUnselectable,
        IFomanticComponentWithInvertedStyle,
        IFomanticComponentWithTooltip
    {
        ///<inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.AddHiddenClass();
            this.AddTooltip();
        }
        ///<inheritdoc/>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            this.AddTooltip();
        }

        ///<inheritdoc/>
        protected internal override void ConstractClasses()
        {
            base.ConstractClasses();
            CssClasses.Insert(0, "ui");              
            this.AddInvertedClass(1).AddUnselectableClass(1).AddSizeClass(1).AddColorClass(1);
            CssClasses.Add("text");
        }

    
        ///<inheritdoc/>
        /// <remarks> 
        /// <para>References : </para>
        /// <para><see href="https://fomantic-ui.com/elements/text.html#size"></see></para>
        /// </remarks>
        [Parameter]
        public Size Size { get; set; } = Size.Medium;

        ///<inheritdoc/>
        /// <remarks> 
        /// <para>References : </para>
        /// <para><see href="https://fomantic-ui.com/elements/text.html#text"></see></para>
        /// </remarks>
        [Parameter]
        public Color? Color { get; set; } = null;

        ///<inheritdoc/>
        /// <remarks> 
        /// <para>References : </para>
        /// <para><see href="https://fomantic-ui.com/elements/text.html#text"></see></para>
        /// </remarks>
        [Parameter]
        public bool IsInverted { get; set; } = false;

        ///<inheritdoc/>
        [Parameter]
        public bool IsUnselectable { get; set; } = false;


        ///<inheritdoc/>
        [Parameter]
        public bool IsTooltipHidden { get; set; }
        ///<inheritdoc/>
        [Parameter]
        public bool IsTooltipBasicFormat { get; set; }
        ///<inheritdoc/>
        [Parameter]
        public bool? IsTooltipInverted { get; set; }
        ///<inheritdoc/>
        [Parameter]
        public string TooltipText { get; set; }
        ///<inheritdoc/>
        [Parameter]
        public TooltipPosition TooltipPosition { get; set; }
        ///<inheritdoc/>
        [Parameter]
        public Size TooltipSize { get; set; }
    }
}
