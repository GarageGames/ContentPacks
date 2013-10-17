singleton TSShapeConstructor(PlayerAnim_Mamba_Crouch_RootDAE)
{
   baseShape = "./PlayerAnim_Mamba_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "300", "359");
}
