# azure-ToDo

The Azure Vote application is a simple sample used throughout the Azure Container Service (AKS) documentation. The application consists of two pods, one running a nodeJs web form, and the second a mongodb instance for data storage.

## Installing the Chart

Add the Azure Samples chart repository.

```
helm repo add azure-samples https://azure-samples.github.io/helm-charts/
```

Install the chart.

```
helm install azure-samples/azure-todo
```


## Configuration

The following tables lists the configurable parameters of the azure-vote chart and the default values.

| Parameter | Description | Default |
|---|---|---|
| title | Azure todo app title. | Azure ToDo App |
| serviceName | Name for Kubernetes service. | azure-todo |
| serviceType | Type for Kubernetes service. | ClusterIP |

## Examples


```
helm install azure-samples/azure-vote --set title="Winter Sports" --set value1=Ski --set value2=Snowboard
```