# Question1: Difference between TempData and ViewBag or ViewData ?
# TempData:
    - Hold data upto **Two Requests**
    - Create Hash Map to Store data into Data-Dictionary
    - After getting value from it, It become NULL
    e.g.
    - TempData["Message"] = "Hello I'm Mudassar";
    - String myMessage = TempData["Message"].ToString();
# ViewBag:
    - Hold data upto **One Request**
    - It returns object, you must cast it
    - Its type is **dynamic**
    e.g.
    - ViewBag.Message = "Hello I'm Mudassar";
    - String myMessage = ViewBag.Message;
# ViewData:
    - Replica of ViewBag
    - You can use it vice versa
    e.g.
    - ViewData["Message"] = "Hello I'm Mudassar";
    - String myMessage = ViewData["Message"].ToString();
                        OR
    - String myMessage = ViewBag.Message;

# Question2: What is dynamic type in C# ?
- The dynamic keyword is used to tell the compiler that a variable's type can change or that it is not known until runtime. Think of it as being able to interact with an Object without having to cast it.
e.g. dynamic myName = ViewData['UserName'].ToString();
- Error on runtime


# Question3: What is DLR ?
- The Dynamic Language Runtime from Microsoft runs on top of the Common Language Runtime and provides computer language services for dynamic languages.

# RenderBody

- If you set layout and don't provide RenderBody. Error will be occured

# RenderSection

- RenderSection("NameofSection",boolean);
    - if boolean==true; Section isn't defined error will be occured
    - if boolean==false; Section isn't defined error will not be occured
@section header {

}
# RenderPartial

# Html.Partial vs Html.RenderPartial 
# Html.Action vs Html.RenderAction

# Virtual Directory ( use of tilde (~) sign)
- It includes the virtual plus the application relative path. ~/ (Root-relative) is an ASP.NET specific path that includes ~/ to indicate the virtual root Web path. ASP.NET can convert virtual paths into either logical paths using Control.ResolveUrl(), or physical paths using Server.MapPath().

# Routing
- What resouces you want to make public 
    routes.MapRoute(
    name = "default",
    url = "~/home/index"
    )
     routes.MapRoute(
    name = "myroute",
    url = "~/home/index"
    )
    e.g. route object creation
    var route{
        controller = "Home";
        action = "Index";
    }

# what are the benefits of Helper Method ?

 - It has overloaded methods to pre-populate the values (formatted, and safe for HTML) just like the ViewState.
 
 - It allows built in support for the Validation features of MVC.

 - It allows you to override the rendering by providing your own DLL for changing the rendering (a sort of "Controller Adapter" type methodology).

 - It leads to the idea of building your own "controls" 

# ViewModel

# Model Binder
 - Model binding in ASP.NET MVC. Model binding is a mechanism ASP.NET MVC uses to create parameter objects defined in controller action methods. The parameters can be of any type, from simple to complex ones.
 fieldid = myname;
 id = roll;
 save(int roll, string myname);
# Difference between customization and configuration ?
 - Customization
 - Configuration

# Data Auditing
- IsActive
- CreatedBy
- CreatedOn
- ModifiedBy
- ModifiedOn
- # Triggers
    - Before or After CRUD operation

# Server Storage
- Application object,Session, Static Classes, Cache
- GlobalDataManager
- SessionManager
- DB
- Files 

# Client Storage
- Local Storage
- Sesssion Storage
- Cookies

