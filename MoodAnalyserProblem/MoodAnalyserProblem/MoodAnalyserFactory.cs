using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using MoodAnalyserProblem;


namespace MoodAnalyserProb
{
    public class MoodAnalyserFactory
    {
        string p = @"." + constructor + "$";
        Match result = Regex.Match(className, p);

            if(result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (Exception)
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
}
                }
                  else
                  {
                    throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
                  }
                }
                   public object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
                   {
                       try
                       {
                      Type type = typeof(MoodAnalyser);
                            if (type.Name.Equals(className) || type.FullName.Equals(className))
                            {
                               if (type.Name.Equals(constructor))
                               {
                              ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                              var obj = constructorInfo.Invoke(new object[] { message });
                              return obj;
                               }
                                else
                                {
                              throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
 
                                }

                            }
                       }
                             catch (Exception)
                               {
                            throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");

                       }
                        return default;
                   }

                    public string InvokeAnalyserMethod(string message, string methodName)
{
    try
    {
        Type type = typeof(MoodAnalyser);

        MethodInfo methodInfo = type.GetMethod(methodName);
        MoodAnalyserFactory factory = new MoodAnalyserFactory();
        object moodAnalyserObject = factory.CreateMoodAnalyserParameterizedObject("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser", message);
        object info = methodInfo.Invoke(moodAnalyserObject, null);
        return info.ToString();
    }
    catch (NullReferenceException)
      {
         throw new CustomException(CustomException.ExceptionType.METHOD_NOT_FOUND, "Method not found");
      }
}