singleton TSShapeConstructor(PlayerAnim_Ender_Crouch_BackDAE)
{
   baseShape = "./PlayerAnim_Ender_Crouch_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Crouch_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Back", "440", "469");
}
