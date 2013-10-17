singleton TSShapeConstructor(PlayerAnim_Ender_Swim_BackDAE)
{
   baseShape = "./PlayerAnim_Ender_Swim_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Swim_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Back", "1450", "1509");
}
