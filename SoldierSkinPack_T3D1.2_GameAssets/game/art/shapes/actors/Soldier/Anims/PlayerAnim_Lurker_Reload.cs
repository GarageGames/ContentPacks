singleton TSShapeConstructor(PlayerAnim_Lurker_ReloadDAE)
{
   baseShape = "./PlayerAnim_Lurker_Reload.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_ReloadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Reload", "1880", "1970");
}
