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

![](RackMultipart20211106-4-s4b1mx_html_b19ce44416062467.png)

- Click on create button.

![](RackMultipart20211106-4-s4b1mx_html_14085c15f9244ed5.png)

- Select and Fill the required fields and hit the &quot;Review + Create&quot; button.

![](RackMultipart20211106-4-s4b1mx_html_79543eb29d8a951e.png)

- Verify details one more time and click on &quot;Create&quot; button.

![](RackMultipart20211106-4-s4b1mx_html_9d115e2266b921c5.png)

- Here we created app configuration resource successfully.
- Now go click on &quot;Access Keys&quot; uunder **settings** blade from left panel.

![](RackMultipart20211106-4-s4b1mx_html_c49cb82fcc3d313c.png)

- As

s