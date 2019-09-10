[assembly: System.CLSCompliant(true)]
namespace Foundations {
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using FndRes = Properties.Resources;

    /// <summary>
    /// Базовый набор данных для всех реализующих классов.
    /// <para/>
    /// <list type="number">
    /// <listheader>
    /// <term>Состоит из следующих данных:</term>
    /// </listheader>
    /// <para/>
    /// <item>
    /// <term><see cref="Title"/></term>
    /// <description> — Название</description>
    /// </item>
    /// <para/>
    /// <item>
    /// <term><see cref="Description"/></term>
    /// <description> — Описание</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IBasicComplex {

        /// <summary>Наименование.</summary>        
        [Display(
            ResourceType = typeof(FndRes),
            Name = "TitleName",
            Description = "TitleDesc",
            GroupName = "BasicDataGroup")]
        [Localizable(true)]
        string Title { get; set; }

        /// <summary>Описание.</summary>
        [Display(
            ResourceType = typeof(FndRes),
            Name = "DescriptionName",
            Description = "DescriptionDesc",
            GroupName = "BasicDataGroup")]
        [Localizable(true)]
        string Description { get; set; }

        /// <summary>Правило проверки строк на <see cref="string.Equals(string, StringComparison)"/>.</summary>
        [DefaultValue(StringComparison.InvariantCultureIgnoreCase)]
        [Display(
            ResourceType = typeof(FndRes),
            Name = "StringComparisonName",
            Description = "StringComparisonDesc",
            GroupName = "DataComparisonGroup")]
        StringComparison StringComparison { get; set; }
    }

}