singleton TSShapeConstructor(PlayerAnim_Ender_Crouch_SideDAE)
{
   baseShape = "./PlayerAnim_Ender_Crouch_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "500", "529");
}
