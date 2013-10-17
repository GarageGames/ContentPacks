singleton TSShapeConstructor(PlayerAnim_Mamba_FallDAE)
{
   baseShape = "./PlayerAnim_Mamba_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "1040", "1069");
}
