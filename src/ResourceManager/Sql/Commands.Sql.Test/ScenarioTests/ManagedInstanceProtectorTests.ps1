﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

$mangedInstanceRg = "MlAndzic_RG"
$managedInstanceName = "midemoinstancebc"
$keyVaultName = "mitest-doNotDelete"
$keyName = "mitest-key"
$keyId = "https://mitest-donotdelete.vault.azure.net/keys/mitest-key/e97043455e14493ca05c3642549aedba"
$keyVersion = "e97043455e14493ca05c3642549aedba"
$tdeKeyName = $keyVaultName + "_" + $keyName + "_" + $keyVersion

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to service managed key 
#>
function Test-SetGetManagedInstanceEncryptionProtectorServiceManaged
{
	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector  -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -Type ServiceManaged
	
	Assert-AreEqual ServiceManaged $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector  -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName
	
	Assert-AreEqual ServiceManaged $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to service managed key for input object parameter set
#>
function Test-SetGetManagedInstanceEncryptionProtectorServiceManagedInputObject
{
	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg

	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstance $managedInstance -Type ServiceManaged
	
	Assert-AreEqual ServiceManaged $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstance $managedInstance
	
	Assert-AreEqual ServiceManaged $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to service managed key for resource id parameter set
#>
function Test-SetGetManagedInstanceEncryptionProtectorServiceManagedResourceId
{

	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg
	$managedInstanceResourceId = $managedInstance.ResourceId

	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstanceResourceId $managedInstanceResourceId -Type ServiceManaged
	
	Assert-AreEqual ServiceManaged $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstanceResourceId $managedInstanceResourceId
	
	Assert-AreEqual ServiceManaged $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to service managed key using piping
#>
function Test-SetGetManagedInstanceEncryptionProtectorServiceManagedPiping
{
	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg

	$encryptionProtector = $managedInstance | Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -Type ServiceManaged
	
	Assert-AreEqual ServiceManaged $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = $managedInstance | Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector
	
	Assert-AreEqual ServiceManaged $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual ServiceManaged $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}



<#
	.SYNOPSIS
	Tests setting and getting encryption protector to azure key vault key 
#>
function Test-SetGetManagedInstanceEncryptionProtectorByok
{
	
	$keyResult = Add-AzureRmSqlManagedInstanceKeyVaultKey -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -KeyId $keyId

	Assert-AreEqual $keyId $keyResult.KeyId "KeyId mismatch after adding managed instance key vault key"
	Assert-AreEqual $tdeKeyName $keyResult.ManagedInstanceKeyName "ManagedInstanceKeyVaultKeyName mismatch after adding managed instance key vault key"

	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector  -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -Type AzureKeyVault -KeyId $keyResult.KeyId -Force
	
	Assert-AreEqual AzureKeyVault $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector  -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName
	
	Assert-AreEqual AzureKeyVault $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to azure key vault key for input object parameter set
#>
function Test-SetGetManagedInstanceEncryptionProtectorByokInputObject
{
	
	$keyResult = Add-AzureRmSqlManagedInstanceKeyVaultKey -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -KeyId $keyId

	Assert-AreEqual $keyId $keyResult.KeyId "KeyId mismatch after adding managed instance key vault key"
	Assert-AreEqual $tdeKeyName $keyResult.ManagedInstanceKeyName "ManagedInstanceKeyVaultKeyName mismatch after adding managed instance key vault key"

	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg

	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstance $managedInstance -Type AzureKeyVault -KeyId $keyResult.KeyId -Force
	
	Assert-AreEqual AzureKeyVault $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstance $managedInstance
	
	Assert-AreEqual AzureKeyVault $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to azure key vault key for resource id parameter set
#>
function Test-SetGetManagedInstanceEncryptionProtectorByokResourceId
{
	
	$keyResult = Add-AzureRmSqlManagedInstanceKeyVaultKey -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -KeyId $keyId

	Assert-AreEqual $keyId $keyResult.KeyId "KeyId mismatch after adding managed instance key vault key"
	Assert-AreEqual $tdeKeyName $keyResult.ManagedInstanceKeyName "ManagedInstanceKeyVaultKeyName mismatch after adding managed instance key vault key"


	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg
	$managedInstanceResourceId = $managedInstance.ResourceId

	$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstanceResourceId $managedInstanceResourceId -Type AzureKeyVault -KeyId $keyResult.KeyId -Force
	
	Assert-AreEqual AzureKeyVault $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -ManagedInstanceResourceId $managedInstanceResourceId
	
	Assert-AreEqual AzureKeyVault $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}

<#
	.SYNOPSIS
	Tests setting and getting encryption protector to azure key vault key using piping
#>
function Test-SetGetManagedInstanceEncryptionProtectorByokPiping
{
	
	$keyResult = Add-AzureRmSqlManagedInstanceKeyVaultKey -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -KeyId $keyId

	Assert-AreEqual $keyId $keyResult.KeyId "KeyId mismatch after adding managed instance key vault key"
	Assert-AreEqual $tdeKeyName $keyResult.ManagedInstanceKeyName "ManagedInstanceKeyVaultKeyName mismatch after adding managed instance key vault key"

	$managedInstance = Get-AzureRmSqlManagedInstance -Name $managedInstanceName -ResourceGroupName $mangedInstanceRg

	$encryptionProtector = $managedInstance | Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector -Type AzureKeyVault -KeyId $keyResult.KeyId -Force
	
	Assert-AreEqual AzureKeyVault $encryptionProtector.Type "Protector type mismatch after setting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after setting managed instance TDE protector"

	$encryptionProtector2 = $managedInstance | Get-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector
	
	Assert-AreEqual AzureKeyVault $encryptionProtector2.Type "Protector type mismatch after getting managed instance TDE protector"
	Assert-AreEqual $keyResult.ManagedInstanceKeyName $encryptionProtector2.ManagedInstanceKeyVaultKeyName "ManagedInstanceKeyVaultKeyName mismatch after getting managed instance TDE protector"
}


<#
	.SYNOPSIS
	Tests setting and getting encryption protector to azure key vault key 
#>
function Test-SetGetManagedInstanceEncryptionProtectorByokFailsWithoutKeyId
{
	$correctExceptionCaught = $false
	$keyResult = Add-AzureRmSqlManagedInstanceKeyVaultKey -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -KeyId $keyId

	Assert-AreEqual $keyId $keyResult.KeyId "KeyId mismatch after adding managed instance key vault key"
	Assert-AreEqual $tdeKeyName $keyResult.ManagedInstanceKeyName "ManagedInstanceKeyVaultKeyName mismatch after adding managed instance key vault key"
	
	try
	{
		$encryptionProtector = Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector  -ResourceGroupName $mangedInstanceRg -ManagedInstanceName $managedInstanceName -Type AzureKeyVault -Force
	}
	Catch
	{
		$isCorrectError =  $_.Exception.Message -like '*KeyId parameter is required for encryption protector type AzureKeyVault*'
		if(!$isCorrectError){
			throw $_.Exception
		}
		$correctExceptionCaught = $true
	}

	if(!$correctExceptionCaught){
		throw [System.Exception] "Expected exception not thrown for cmdlet Set-AzureRmSqlManagedInstanceTransparentDataEncryptionProtector when encryptor is AzureKeyVault and KeyId is not provided"
	}
}