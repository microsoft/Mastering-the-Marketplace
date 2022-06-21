# Packer 
This module explains how to setup Packer and run a simple deployment of a VM image with a server installed and finally create a VM using the created image.

> You need to have Packer installed in order to run this exercise. You can find ways to download Packer here : [Packer Download](https://www.packer.io/downloads)

Once you have packer downloaded, you can verify the installation by following the steps laid out here: [Verify Packer Installation](https://learn.hashicorp.com/tutorials/packer/get-started-install-cli#verifying-the-installation) 

There are detailed steps available to start a Packer implementation on Azure, you will find them here: [Microsoft Packer Documentation](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/build-image-with-packer)

<br>

## Step 1: Run the azresource.ps1 script 
Run the below command to setup resources 
``` .\az-resource.ps1 ```
The az-resource.ps1 script will create 2 resource groups, a service principal, a shared image gallery and an image definition. The first resource group will be used to save the image version and the second to store temporary resources. You may change the naming conventions in the script to match your requirements.

## Step 2: Packer Build
Run the below command within the folder where you cloned the Packer script. We will execute the packerlinux.json file. 

``` packer build -var location=westus2 -var sig_gallery_resource_group=myResourceGroup -var sig_gallery_name=packergallery -var sig_image_name=packerimagedefn -var sig_image_version=1.0.0 .\Packer\packerlinux.json ```

This will start creating the image in the image definition for use.