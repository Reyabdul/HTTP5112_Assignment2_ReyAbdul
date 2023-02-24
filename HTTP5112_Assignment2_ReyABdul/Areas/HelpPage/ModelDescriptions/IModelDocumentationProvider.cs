using System;
using System.Reflection;

namespace HTTP5112_Assignment2_ReyABdul.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}