singleton TSShapeConstructor(PlayerAnim_Ender_BackDAE)
{
   baseShape = "./PlayerAnim_Ender_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "240", "259");
}
