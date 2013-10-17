singleton TSShapeConstructor(PlayerAnim_Mamba_HeadDAE)
{
   baseShape = "./PlayerAnim_Mamba_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "900", "910");
}
