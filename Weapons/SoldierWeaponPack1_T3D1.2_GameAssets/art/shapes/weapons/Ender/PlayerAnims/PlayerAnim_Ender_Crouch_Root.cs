singleton TSShapeConstructor(PlayerAnim_Ender_Crouch_RootDAE)
{
   baseShape = "./PlayerAnim_Ender_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "290", "349");
}
