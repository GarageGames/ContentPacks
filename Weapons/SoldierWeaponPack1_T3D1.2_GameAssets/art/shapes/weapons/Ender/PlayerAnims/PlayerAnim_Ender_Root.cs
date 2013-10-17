singleton TSShapeConstructor(PlayerAnim_Ender_RootDAE)
{
   baseShape = "./PlayerAnim_Ender_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "50", "109");
}
