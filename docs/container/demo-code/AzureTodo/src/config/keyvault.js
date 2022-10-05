const { DefaultAzureCredential } = require("@azure/identity");
const { SecretClient } = require("@azure/keyvault-secrets");

const getSecret = async (secretName, keyVaultName) => {

    if (!secretName || !keyVaultName) {
        throw Error("getSecret: Required params missing")
    }
   
    const credential = new DefaultAzureCredential();
     
    // Build the URL to reach your key vault
    const url = `https://${keyVaultName}.vault.azure.net`;
     
    try {
        // Create client to connect to service
        const client = new SecretClient(url, credential);
       
        // Get secret Obj
        const latestSecret = await client.getSecret(secretName);
       
        console.log(`Secret (${secretName}=${latestSecret.value})`)

        // Return value
        return latestSecret.value;
    } catch (ex) {
        console.log(ex)
        throw ex;
    }
}

module.exports = {
    getSecret
  }