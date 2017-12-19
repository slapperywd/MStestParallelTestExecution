# Trying to perform tests in parallel (MStest is used)
Since MStest V2 has been released Visual studio 2017 allows you to run your tests parallely by clicking "Run tests in paralell" icon on the top of Test Explorer.

In previous version you could create  ```name.runSettings``` with the following content

```sh
<?xml version="1.0" encoding="utf-8"?>  
<RunSettings>  
  <!-- Configurations that affect the Test Framework -->  
  <RunConfiguration>  
    <MaxCpuCount>0</MaxCpuCount>  //0 will use all available cores
  </RunConfiguration>  
</RunSettings>
```

# One moment to be mentioned
Unfortunately only tests located in different projects (DLLs) can be run concurrently.
There is no support to run your tests in paralell within the same project.
