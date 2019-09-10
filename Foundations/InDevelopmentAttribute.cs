using System;


namespace Foundations {

    /// <summary>Атрибут элемента, находящегося в разработке.</summary>
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    [System.Runtime.InteropServices.ComVisible(true)]
    [Serializable]
    public sealed class InDevelopmentAttribute : Attribute {

        public InDevelopmentAttribute() {
            Message = "Элемент находится в разработке.";
        }

        public InDevelopmentAttribute(string message) {
            Message = message;
        }

        public string Message { get; }

    }
}
