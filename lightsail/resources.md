## Additional information about container services

These are the general steps to manage your Lightsail container service after it's up and running:

1. Get familiar with all of the elements of Lightsail container services. For more information, see [Container services in Amazon Lightsail](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-container-services).
    
2. Create your container service in your Lightsail account. For more information, see [Creating Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-services).
    
3. If you plan to use container images from a public registry, find container images that you want to use from a public registry like the Amazon ECR Public Gallery or Docker Hub. For more information about Amazon ECR Public, see [What Is Amazon Elastic Container Registry Public?](https://docs.aws.amazon.com/AmazonECR/latest/public/what-is-ecr.html) in the Amazon ECR Public User Guide. For more information about Docker Hub, see [Docker Hub Quickstart](https://docs.docker.com/docker-hub/) in the Docker documentation.
    
4. If you plan to push container images from your local machine to your service, install software on your local machine that you need to create your own container images and push them to your Lightsail container service. For more information, see the following guides:
    
    - [Installing software to manage container images for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-install-software)
        
    - [Creating container images for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-images)
        
    - [Pushing and managing container images on your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-pushing-container-images)
        
5. Create a deployment in your container service that configures and launches your containers. For more information, see [Creating and managing deployments for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-container-services-deployments).
    
6. View previous deployments for your container service. You can create a new deployment using a previous deployment version. For more information, see [Viewing and managing deployment versions of your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-container-services-deployment-versions).
    
7. View the logs of containers on your container service. For more information, see [Viewing the container logs of your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-viewing-container-service-container-logs).
    
8. Create an SSL/TLS certificate for the domains that you want to use with your containers. For more information, see [Creating SSL/TLS certificates for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-services-certificates).
    
9. Validate the SSL/TLS certificate by adding records to the DNS of your domains. For more information, see [Validating SSL/TLS certificates for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-validating-container-services-certificates).
    
10. Enable custom domains by attaching a valid SSL/TLS certificate to your container service. For more information, see [Enabling and managing custom domains for your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-enabling-container-services-custom-domains).
    
11. Monitor the utilization metrics of your container service. For more information, see [Viewing container service metrics in Amazon Lightsail](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-viewing-container-services-metrics).
    
12. (Optional) Scale the capacity of your container service vertically, by increasing its power specification, and horizontally, by increasing its scale specification. For more information, see [Changing the capacity of your Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-changing-container-service-capacity).
    
13. Delete your container service if you're not using it to avoid incurring monthly charges. For more information, see [Deleting Amazon Lightsail container services](https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-deleting-container-services).