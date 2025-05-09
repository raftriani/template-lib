# Boas Práticas para criação de uma biblioteca .NET  

## Estrutura do Projeto  
1. **Organização de Pastas**:  
  - `src/`: Contém o código-fonte da biblioteca.  
  - `tests/`: Contém os projetos de teste unitário e de integração.  
  - `docs/`: Documentação adicional, como guias de uso e exemplos.  

2. **Nomenclatura**:  
  - Use nomes claros e descritivos que reflitam o propósito da biblioteca.
  - Siga o padrão `Empresa.Produto.Funcionalidade` (ex.: `Evertec.Extensions.Binding.TenantProvider`).
  - Evite abreviações desnecessárias.

3. **Versionamento**:  
  - Siga o [Semantic Versioning (SemVer)](https://semver.org/): `MAJOR.MINOR.PATCH`.  
    - `MAJOR`: Alterações incompatíveis.
    - `MINOR`: Novas funcionalidades compatíveis.
    - `PATCH`: Correções de bugs.
  - Atualize a versão no arquivo `.csproj`  

## Configuração do Projeto  
1. **Target Framework**:  
  - Use o framework mais recente e estável, como `.NET 8`.  
  - Configure múltiplos frameworks no `.csproj` se necessário:
    ```xml
      <TargetFrameworks>net8.0;net6.0</TargetFrameworks>
    ```
2. **Dependências**:  
   - Evite dependências desnecessárias para manter a biblioteca leve.  
   - Use versões estáveis e amplamente suportadas de pacotes comuns, como:  
     - `Newtonsoft.Json` (se necessário, mas prefira `System.Text.Json` para melhor performance).  
     - `Microsoft.Extensions.*` para injeção de dependência e configuração.  

3. **Análise de Código**:  
   - Ative os analisadores de código no `.csproj`:

4. **Nullable Reference Types**:  
   - Habilite o suporte a tipos nulos para evitar erros:

5. **IsPackable:**: 
    - Habilite a opção para que o .nupkg seja gerado
    ```xml
    <IsPackable>true</IsPackable> 
    ```

## Boas Práticas de Código  
1. **SOLID**:  
   - Siga os princípios SOLID para garantir um design limpo e extensível.  

2. **Documentação**:  
   - Use comentários XML para documentar classes, métodos e propriedades.  
   ```c#
    /// <summary>
    /// Classe responsável por gerenciar o provedor de tenants.
    /// </summary>
    public class TenantProvider { }
    ```

3. **Testes**:  
   - Escreva testes unitários para todas as funcionalidades principais.  
   - Use frameworks como `xUnit` ou `NUnit`.  
   - Garanta alta cobertura de código, mas priorize qualidade sobre quantidade. Recomendamos pelo menos uma cobertura de 90%. 

4. **Logging**:  
   - Use `Microsoft.Extensions.Logging` para logging configurável.  

## Publicação  
1. **Pacote NuGet**:  
   - Configure o `.csproj` para gerar pacotes NuGet:
2. **README.md**:  
   - Inclua um arquivo `README.md` no pacote com instruções de uso.  

3. **Automação**:  
   - Use pipelines de CI/CD (como GitHub Actions ou Azure DevOps) para automatizar build, testes e publicação.  

## Backstage  - Considerações
1. **Catalógo**:  
   - Na raiz do projeto deverá ter um arquivo `catalog-info.yaml` para poder gerar o católogo no Backstage:
   - Exemplo do arquivo:
   ```yaml
   apiVersion: backstage.io/v1alpha1
      kind: Component
      metadata:
      name: cross-plataforma-net-lib
      description: A simple api in python
      annotations:
         github.com/project-slug: SQ-Sandbox/cross-plataforma-net-lib
         backstage.io/techdocs-ref: dir:.
      spec:
      type: service
      owner: Sinqia
      lifecycle: experimental
   ```

   - A propridade **name** deve ser o nome da sua biblioteca.
   - A propridade **github.com/project-slug** deve ser o caminho do seu repositório.

2. **Tech Docs**:  
   - Na raiz do projeto deverá ter uma pasta `docs` e dentro dela um arquivo `index.md` no pacote com instruções de uso. Esse arquivo deverá  ter a documentação da sua biblioteca que será indexada no TechDocs no Backstage. 

3. **Automação**:  
   - Use pipelines de CI/CD (como GitHub Actions ou Azure DevOps) para automatizar build, testes e publicação.  

## Considerações Finais  
- Mantenha a biblioteca simples e focada em resolver um problema específico.  
- Atualize regularmente para acompanhar as melhores práticas e novas versões do .NET.  
- Escute o feedback da comunidade e melhore continuamente.
