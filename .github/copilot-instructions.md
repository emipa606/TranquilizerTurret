# GitHub Copilot Instructions for Tranquilizer Turret (Continued) Mod

## Mod Overview and Purpose

**Tranquilizer Turret (Continued)** is an updated version of TheGoofyOnes' Tranquilizer Turret mod for the RimWorld game. This mod allows your turrets to target prisoners again, enhancing the gameplay experience by providing an additional strategy. It is designed to be safe to add to your existing game without interfering with core files, making it a versatile addition to any RimWorld mod setup.

## Key Features and Systems

### Research and Targeting
- **Research**: Players can research the necessary technology to unlock the tranquilizer turret.
- **Targeting**: Turrets are modified to target prisoners, adding a new layer of strategy to the game.

### Additional Settings
- **Disable Vomiting**: A setting has been added to disable the vomiting effect caused by the tranquilizer, providing more control over the mod's behavior.

## Coding Patterns and Conventions

### C# Code Structure
- **Mod Entry Point**: The `NonLethalWeaponsMod` class serves as the entry point for the mod, handling initialization and settings.
- **Settings Management**: The `NonLethalWeaponsSettings` class manages the mod's settings, including the disable vomiting option.
- **Projectile Definitions**: Classes like `Projectile_NLW_BeanBag` and `Projectile_NLW_TranquilizerDart` define the behavior of different projectiles used by the turrets.

### XML Integration
- **HediffDefs**: The `Tranquilizer.xml` file defines the hediff associated with the tranquilizer.
- **ResearchProjectDefs**: The `ResearchProjects_Tier2_Turrets.xml` file outlines the research needed to unlock the tranquilizer turret.
- **SoundDefs**: The `World_Oneshots_Turrets.xml` file includes sound effects for the turrets.
- **ThingDefs**: The `Buildings_Security.xml` file defines the turret's properties and interactions.

### Harmony Patching
The mod uses Harmony patching to modify vanilla game behavior without directly altering core files. Key patches include:
- **Turret Targeting**: Adjusting the targeting logic to allow turrets to target prisoners.
- **Projectile Behavior**: Customizing the impact behavior of tranquilizer darts and bean bags.

## Suggestions for Copilot

### General Recommendations
- Use clear and descriptive variable and method names to enhance readability and maintainability.
- Follow RimWorld's coding conventions and patterns to ensure compatibility and ease of integration.

### XML Best Practices
- Ensure all XML definitions are correctly formatted and adhere to RimWorld's XML schema.
- Use comments within XML files to explain complex configurations or settings.

### Harmony Patching Tips
- When creating Harmony patches, clearly document the purpose and effects of each patch.
- Test patches thoroughly to ensure they do not introduce bugs or unintended behavior.

### Collaboration
- Encourage pull requests for bug fixes and new features.
- Use the GitHub repository for discussions and error reporting.

### Community Engagement
- Promote the use of the Discord channel for error reporting and support.
- Encourage community contributions and solutions through the repository.

By following these guidelines, you can contribute to the Tranquilizer Turret (Continued) mod in a way that enhances its functionality and maintains high-quality standards.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

