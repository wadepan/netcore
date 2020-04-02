using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;


namespace ModelBinder.ModelBinder
{
    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var values = bindingContext.ValueProvider.GetValue("Value"); 
    
            return Task.CompletedTask;
        }
    }



        public class CustomModelBinderProvider : IModelBinderProvider
        {
            public IModelBinder GetBinder(ModelBinderProviderContext context)
            {
                //if (context.Metadata.ModelType == typeof(User))
                    return new CustomModelBinder();

                //return null;
            }
        }
    }
