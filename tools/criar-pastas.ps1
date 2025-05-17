# Script PowerShell para padronizar estrutura de pastas dos projetos em src/dropshipping

$root = "src/dropshipping"
$foldersToCreate = @(
    "Application",
    "Application/Commands",
    "Application/Queries",
    "Domain",
    "Infrastructure",
    "Services"
)

Get-ChildItem -Path $root -Directory | ForEach-Object {
    $projectPath = $_.FullName
    foreach ($folder in $foldersToCreate) {
        $fullPath = Join-Path $projectPath $folder
        if (-not (Test-Path $fullPath)) {
            New-Item -ItemType Directory -Path $fullPath | Out-Null
        }
    }
}

Write-Host "Pastas padronizadas criadas em todos os projetos de src/dropshipping."
