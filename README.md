# Read And Publish Values for Azure App Configuration

In this article we will learn how to read values from azure app configuration as well as how to publish values to azure app configuration by using C# language.

We need some experience on Azure and C# language.

## What is Azure App Configuration?

- Azure app configuration is a resource in azure which provides a service to centrally manage application settings and feature flags.
- It allows user to manage configuration within cloud.
- User can create app configuration to store Key-Value settings and consume (Read) it in application.

**Use Case:**

- As we know azure configuration provides a service to centrally manage application settings.
- If we have more than one application and they uses same configuration settings, then no need to manage configuration settings individually to each application.
- We simple create app configuration in azure and manage from there to all applications.

## Let&#39;s Start With Hands On Example:

**Pre-requisite**

Before proceeding to start, let&#39;s check out the  **pre-requirements**  for this, given below:

- .Net Core (MVC etc)
- C# \&gt; 7.0
- An Azure Account
- Code Editor (VS or VS Code)

**Step1:** Lets create an app configuration resource in azure.

- Login to your azure subscription [Azure Portal](https://portal.azure.com/).

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/1.jpg)

- Search for app configuration by the help of search text box.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/fcc2ed69fa72c4e8844f0c4956d515311abbb1fd/Images/2.jpg)

- Click on create button.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/3.jpg)

- Select and Fill the required fields and hit the &quot;Review + Create&quot; button.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/3.jpg)

- Verify details one more time and click on &quot;Create&quot; button.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/5.jpg)

- Here we created app configuration resource successfully.
- Now click on &quot;Access Keys&quot; under **settings** blade from left panel.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/6.jpg)

- As we are going to read and push values to app configuration, so we need to select &quot;Read-Write Keys&quot; tab and for getting connection string for both action.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/7.png)

- Now we check is there any key value is available or not in this. let's go and check.
- Click on &quot;Configuration exporer&quot; under **Operations** blade from left panel.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/8.png)

- As shown above picture there is no key-values are available.

**Step2:** Lets create MVC core application for read and push values to app configuration.
- Let's switch to visual studio and create mvc application.

![](https://github.com/Firdos7691/AppConfigurationReadAndPush/blob/main/Images/9.png)

- Add below nuget pakcages to project.<br/>
    **Microsoft.Azure.AppConfiguration.AspNetCore**