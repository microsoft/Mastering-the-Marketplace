---
# Page settings
layout: default
keywords: Azure AppSoure Marketplace Virtual Machine
comments: false
hide:
  - navigation


# Hero section
title: Mastering Virtual Machine Offers
description: The content in this course is from a live hands-on workshop. These demo-heavy modules take you all the way from creating a new virtual machine in Azure through publishing a custom virtual machine offer to the Microsoft commercial marketplace. If you are looking to publish a new virtual machine offer, this series will get you from beginner to advanced in a short time.

---

The content in this course is from a live hands-on workshop. These demo-heavy modules take you all the way from creating a new virtual machine in Azure through publishing a custom virtual machine offer to the Microsoft commercial marketplace. If you are looking to publish a new virtual machine offer, this series will get you from beginner to advanced in a short time.

---

**[Let us know what you need](https://forms.office.com/r/0gCrzhSMkw)** in this content library.


Get your hands dirty with the [hands-on labs](#hands-on-labs).

Neelavarsha Duddanahalli Kumar Mahesh and Julio Colon are the creators of this course.

---

## Creating Virtual Machine Offers Overview

<a href="https://go.microsoft.com/fwlink/?linkid=2197805" target="_blank">Video</a>

This introductory module takes you from start to finish in creating and publishing virtual machine offers in the Microsoft commercial marketplace. Get an overview of the process from beginning to end before embarking on the more technical details in later modules.

## Partner Center Overview

<a href="https://go.microsoft.com/fwlink/?linkid=2197586" target="_blank">Video</a>

Learn about creating your offers in Partner Center, including private plans, CRM integration, and more.

## Creating an Offer in Partner Center (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197587" target="_blank">Video</a>

See how to create an offer in Partner Center to include creating the offer, configuring a basic CRM integration, specifying offer properties, listing details, and resell with CSP settings. This video does not go into the specifics of creating the Virtual Machine plans for the offer, which will be seen in a later demo.

## Creating and Customizing a Virtual Machine (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197588" target="_blank">Video</a>

Learn how to not only create a Virtual Machine, but how to customize it by adding scripts or applications. This is a required step in creating your Virtual Machine offer so that the Virtual Machine itself has your intellectual property installed on it.

## Generalizing and Capturing a Virtual Machine Image

<a href="https://go.microsoft.com/fwlink/?linkid=2197589" target="_blank">Video</a>

Learn what it means to generalize and capture a Virtual Machine so it can be made available in your offer. The examples provided in this overview pertain to both Windows and Linux machines.

## Generalizing and Capturing a Virtual Machine Image (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197497" target="_blank">Video</a>

See how to capture both a Linux and Windows Virtual Machine for use in your marketplace offer. This demo is done with a Linux machine, but the difference for Windows is explained along the way. Most actions taken are applicable to both machine types and this module gives you what you need to know to generalize and capture both machine types.

## Publish Your Virtual Machine Offer with Partner Center (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197498" target="_blank">Video</a>

This demonstration takes you through creating a plan for your Virtual Machine offer, associating the correct image to the plan, and setting other configuration options on your Virtual Machine. After completing the plan configuration you get to see the offer published.

## Securing Your Virtual Machine

<a href="https://go.microsoft.com/fwlink/?linkid=2197298" target="_blank">Video</a>

Learn about things you can do to secure your Virtual Machine offer and the image used to create it. There are plenty of techniques you can use to harden your Virtual Machine against attackers and this video will take you through several.

## Virtual Machine Automation with Packer Overview

<a href="https://go.microsoft.com/fwlink/?linkid=2197900" target="_blank">Video</a>

Learn about the Packer tool that enables automating many of the tasks you’ve seen done by hand up until now. Packer gives you the power to create virtual machines, install software, create images, and more.

## Virtual Machine Automation with Packer (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197723" target="_blank">Video</a>

See how the Packer tool gives you the power to automate many of the tasks needed to created Virtual Machine images for your Virtual Machine offer. This walkthrough using VS Code and the command line leaves you with the tools you need to begin your own automation.

## The Virtual Machine Offer Certification Process 

<a href="https://go.microsoft.com/fwlink/?linkid=2197191" target="_blank">Video</a>

This quick lecture walks through the Virtual Machine offer certification process and details common reasons why certification may fail for a newly submitted virtual machine offer. This video can save you loads of time by helping you avoid common mistakes or misunderstandings.

## Virtual Machine Certification Test Tool (Demo)

<a href="https://go.microsoft.com/fwlink/?linkid=2197192" target="_blank">Video</a>

There is a tool one can use to help prepare their Virtual Machine image for certification. The Virtual Machine image certification tool is exercised in this video, and we get to see how to set it up and use it to gain confidence that a Virtual Machine image will not be rejected during certification.

## Purchasing the Virtual Machine Offer

<a href="https://go.microsoft.com/fwlink/?linkid=2197724" target="_blank">Video</a>

The offer is now complete and ready to test in Partner Center. In this video, experience buying the completed Virtual Machine offer from the point of view of the customer.

---

## Hands-on labs

The following hands-on labs build upon each other. They take you through the complete process of creating and publishing a virtual machine offer in the Microsoft commercial marketplace. 

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

### Prerequisites

- An Azure Subscription to create resources
- An active Partner Center Account (Please ensure you have enrolled into the Marketplace Offers program)
- Visual Studio Code or other text editor

### Labs

1. [Partner Center Setup](./Labs/lab1-partner-center-setup/index.md)
2. [VM Creation](./Labs/lab2-vm-creation/index.md)
3. [Generalize and Capture Image](Labs/lab3-generalize-and-capture-image/index.md)
4. [Publish the Offer](./Labs/lab4-publish-your-vm-offer/index.md)
5. [Purchase your Offer](Labs/lab5-purchase-your-offer/index.md)